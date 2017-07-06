﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Net.Sockets;
using System.Net;
using System.IO;

namespace ChatServer
{
    public partial class FServer : Form
    {
        public FServer()
        {
            InitializeComponent();
            //关闭对文本框的非法线程操作检查
            TextBox.CheckForIllegalCrossThreadCalls = false;
        }
        //分别创建一个监听客户端的线程和套接字
        Thread threadWatch = null;
        Socket socketWatch = null;

        public const int SendBufferSize = 2 * 1024;
        public const int ReceiveBufferSize = 8 * 1024;

        private void btnStartService_Click(object sender, EventArgs e)
        {
            //定义一个套接字用于监听客户端发来的信息  包含3个参数(IP4寻址协议,流式连接,TCP协议)
            socketWatch = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            //发送信息 需要1个IP地址和端口号
            //获取服务端IPv4地址
            IPAddress ipAddress = GetLocalIPv4Address();
            lblIP.Text = ipAddress.ToString();
            //给服务端赋予一个端口号
            int port = 30;
            lblPort.Text = port.ToString();

            //将IP地址和端口号绑定到网络节点endpoint上 
            IPEndPoint endpoint = new IPEndPoint(ipAddress, port);
            //将负责监听的套接字绑定网络端点
            socketWatch.Bind(endpoint);
            //将套接字的监听队列长度设置为20
            socketWatch.Listen(20);
            //创建一个负责监听客户端的线程 
            threadWatch = new Thread(WatchConnecting);
            //将窗体线程设置为与后台同步
            threadWatch.IsBackground = true;
            //启动线程
            threadWatch.Start();
            txtMsg.AppendText("服务器已经启动,开始监听客户端传来的信息!" + "\r\n");
            btnStartService.Enabled = false;
        }

        /// <summary>
        /// 获取本地IPv4地址
        /// </summary>
        /// <returns>本地IPv4地址</returns>
        public IPAddress GetLocalIPv4Address()
        {
            IPAddress localIPv4 = null;
            //获取本机所有的IP地址列表
            IPAddress[] ipAddressList = Dns.GetHostAddresses(Dns.GetHostName());
            foreach (IPAddress ipAddress in ipAddressList)
            {
                //判断是否是IPv4地址
                if (ipAddress.AddressFamily == AddressFamily.InterNetwork) //AddressFamily.InterNetwork表示IPv4 
                {
                    localIPv4 = ipAddress;
                }
                else
                    continue;
            }
            return localIPv4;
        }

        //用于保存所有通信客户端的Socket
        Dictionary<string, Socket> dicSocket = new Dictionary<string, Socket>();

        //创建与客户端建立连接的套接字
        Socket socConnection = null;
        string clientName = null; //创建访问客户端的名字
        IPAddress clientIP; //访问客户端的IP
        int clientPort; //访问客户端的端口号
        /// <summary>
        /// 持续不断监听客户端发来的请求, 用于不断获取客户端发送过来的连续数据信息
        /// </summary>
        private void WatchConnecting()
        {
            while (true)
            {
                try
                {
                    socConnection = socketWatch.Accept();
                }
                catch (Exception ex)
                {
                    txtMsg.AppendText(ex.Message); //提示套接字监听异常
                    lstClients.Items.Remove(clientName); //在客户端列表添加该访问客户端的唯一标识
                    dicSocket.Remove(clientName); //将客户端名字和套接字添加到添加到数据字典中
                    break;
                }
                //获取访问客户端的IP
                clientIP = (socConnection.RemoteEndPoint as IPEndPoint).Address;
                //获取访问客户端的Port
                clientPort = (socConnection.RemoteEndPoint as IPEndPoint).Port;
                //创建访问客户端的唯一标识 由IP和端口号组成 
                clientName = "IP: " + clientIP +" Port: "+ clientPort;
                lstClients.Items.Add(clientName); //在客户端列表添加该访问客户端的唯一标识
                dicSocket.Add(clientName, socConnection); //将客户端名字和套接字添加到添加到数据字典中

                //创建通信线程 
                ParameterizedThreadStart pts = new ParameterizedThreadStart(ServerRecMsg);
                Thread thread = new Thread(pts);
                thread.IsBackground = true;
                //启动线程
                thread.Start(socConnection);
                txtMsg.AppendText("IP: " + clientIP + " Port: " + clientPort + " 的客户端与您连接成功,现在你们可以开始通信了...\r\n");
            }
        }

        /// <summary>
        /// 发送信息到客户端的方法
        /// </summary>
        /// <param name="sendMsg">发送的字符串信息</param>
        private void ServerSendMsg(string sendMsg)
        {
            sendMsg = txtSendMsg.Text.Trim();
            //将输入的字符串转换成 机器可以识别的字节数组
            byte[] arrSendMsg = Encoding.UTF8.GetBytes(sendMsg);
            //向客户端列表选中的客户端发送信息
            if (!string.IsNullOrEmpty(lstClients.Text.Trim())) 
            {
                //获得相应的套接字 并将字节数组信息发送出去
                dicSocket[lstClients.Text.Trim()].Send(arrSendMsg);
                //通过Socket的send方法将字节数组发送出去
                txtMsg.AppendText("您在 " + GetCurrentTime() + " 向 IP: " + clientIP + " Port: " + clientPort + " 的客户端发送了:\r\n" + sendMsg + "\r\n");
            }
            else //如果未选择任何客户端 则默认为群发信息
            {
                //遍历所有的客户端
                for (int i = 0; i < lstClients.Items.Count; i++)
                {
                    dicSocket[lstClients.Items[i].ToString()].Send(arrSendMsg);
                }
                txtMsg.AppendText("您在 " + GetCurrentTime() + " 群发了信息:\r\n" + sendMsg + " \r\n");
            }
        }

        string strSRecMsg = null;
        /// <summary>
        /// 接收客户端发来的信息
        /// </summary>
        private void ServerRecMsg(object socketClientPara)
        {
            Socket socketServer = socketClientPara as Socket;

            long fileLength = 0;
            while (true)
            {
                int firstReceived = 0;
                byte[] buffer = new byte[ReceiveBufferSize];
                try
                {
                    //获取接收的数据,并存入内存缓冲区  返回一个字节数组的长度
                    if (socketServer != null) firstReceived = socketServer.Receive(buffer);

                    if (firstReceived > 0) //接受到的长度大于0 说明有信息或文件传来
                    {
                        if  ((buffer[0] != 1) |  (buffer[0] != 2 ) ) //0为文字信息
                        {
                            strSRecMsg = Encoding.UTF8.GetString(buffer, 0, firstReceived);//真实有用的文本信息要比接收到的少1(标识符)
                            txtMsg.AppendText("SoFlash:" + GetCurrentTime() + "\r\n" + strSRecMsg + "\r\n");
                        }
                        if (buffer[0] == 2)//2为文件名字和长度
                        {
                            string fileNameWithLength = Encoding.UTF8.GetString(buffer, 1, firstReceived - 1);
                            strSRecMsg = fileNameWithLength.Split('-').First(); //文件名
                            fileLength = Convert.ToInt64(fileNameWithLength.Split('-').Last());//文件长度
                        }
                        if (buffer[0] == 1)//1为文件
                        {
                            string fileNameSuffix = strSRecMsg.Substring(strSRecMsg.LastIndexOf('.')); //文件后缀
                            SaveFileDialog sfDialog = new SaveFileDialog()
                            {
                                Filter = "(*" + fileNameSuffix + ")|*" + fileNameSuffix + "", //文件类型
                                FileName = strSRecMsg
                            };

                            //如果点击了对话框中的保存文件按钮 
                            if (sfDialog.ShowDialog(this) == DialogResult.OK)
                            {
                                string savePath = sfDialog.FileName; //获取文件的全路径
                                //保存文件
                                int received = 0;
                                long receivedTotalFilelength = 0;
                                bool firstWrite = true;
                                using (FileStream fs = new FileStream(savePath, FileMode.Create, FileAccess.Write))
                                {
                                    while (receivedTotalFilelength < fileLength) //之后收到的文件字节数组
                                    {
                                        if (firstWrite)
                                        {
                                            fs.Write(buffer, 1, firstReceived - 1); //第一次收到的文件字节数组 需要移除标识符1 后写入文件
                                            fs.Flush();

                                            receivedTotalFilelength += firstReceived - 1;

                                            firstWrite = false;
                                            continue;
                                        }
                                        received = socketServer.Receive(buffer); //之后每次收到的文件字节数组 可以直接写入文件
                                        fs.Write(buffer, 0, received);
                                        fs.Flush();

                                        receivedTotalFilelength += received;
                                    }
                                    fs.Close();
                                }

                                string fName = savePath.Substring(savePath.LastIndexOf("\\") + 1); //文件名 不带路径
                                string fPath = savePath.Substring(0, savePath.LastIndexOf("\\")); //文件路径 不带文件名
                                txtMsg.AppendText("天之涯:" + GetCurrentTime() + "\r\n您成功接收了文件" + fName + "\r\n保存路径为:" + fPath + "\r\n");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    txtMsg.AppendText("系统异常消息:" + ex.Message);
                    break;
                }
            }
        }

        //将信息发送到到客户端
        private void btnSendMsg_Click(object sender, EventArgs e)
        {
            ServerSendMsg(txtSendMsg.Text);
        }

        //快捷键 Enter 发送信息
        private void txtSendMsg_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ServerSendMsg(txtSendMsg.Text);
            }
        }

        /// <summary>
        /// 获取当前系统时间
        /// </summary>
        public DateTime GetCurrentTime()
        {
            DateTime currentTime = new DateTime();
            currentTime = DateTime.Now;
            return currentTime;
        }

        //关闭服务端
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //取消客户端列表选中状态
        private void btnClearSelectedState_Click(object sender, EventArgs e)
        {
            lstClients.SelectedItem = null;
        }
    }
}
