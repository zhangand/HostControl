﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Threading;
using System.Net;
using System.IO;

namespace FTClient
{
    public partial class FTClient : Form
    {
        public FTClient()
        {
            InitializeComponent();
            //关闭对文本框的非法线程操作检查
            TextBox.CheckForIllegalCrossThreadCalls = false;
            btnDisConnectToServer.Enabled = false;
            gbxSiteSelect.Enabled = false;
            gbxCommand.Enabled = false;
            txtCMsg.Enabled = false;
            btnCSend.Enabled = false;
            timer1.Start();
        }
        //创建 1个客户端套接字 和1个负责监听服务端请求的线程  
        Socket socketClient = null;
        Thread threadClient = null;

        public const int SendBufferSize = 2 * 1024;
        public const int ReceiveBufferSize = 8 * 1024;
        public string strRecMsg = null;
        public long SiteIndex = 0;
        public int count = 0;

        private void btnConnectToServer_Click(object sender, EventArgs e)
        {
            //定义一个套字节监听  包含3个参数(IP4寻址协议,流式连接,TCP协议)
            socketClient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            
            //获取文本框输入的服务端IP和Port
            IPAddress serverIPAddress = IPAddress.Parse(txtIP.Text.Trim());
            int serverPort = int.Parse(txtPort.Text.Trim());
            IPEndPoint endpoint = new IPEndPoint(serverIPAddress, serverPort);
            try
            {
                //向指定的ip和端口号的服务端发送连接请求 用的方法是Connect 不是Bind
                socketClient.Connect(endpoint);
 
                //创建一个新线程 用于监听服务端发来的信息
                threadClient = new Thread(RecMsg);
                //将窗体线程设置为与后台同步
                threadClient.IsBackground = true;
                //启动线程
                threadClient.Start();
                txtMsg.AppendText("Connected server, start communication...\r\n");
                btnConnectToServer.Enabled = false;
                btnDisConnectToServer.Enabled = true;
                gbxSiteSelect.Enabled = true;   
                txtCMsg.Enabled = true;
                btnCSend.Enabled = true;
             
            }
            catch (SocketException ex)
            {
                txtMsg.AppendText("Socker error message:" + ex.Message + "\r\n");
            }
        }
  
        private void btnDisConnectToServer_Click(object sender, EventArgs e)
        {
            //定义一个套字节监听  包含3个参数(IP4寻址协议,流式连接,TCP协议)
            btnConnectToServer.Enabled = true;
            btnDisConnectToServer.Enabled = false;
            gbxSiteSelect.Enabled = false;
            gbxCommand.Enabled = false;
            txtCMsg.Enabled = false;
            btnCSend.Enabled = false;
            //checkedListBox1.SetItemChecked = null;
            txtMsg.AppendText("Disconnected server...\r\n");
            socketClient.Close();
        }
        /// <summary>
        /// 接受服务端发来信息的方法
        /// </summary>
        public void RecMsg()
        {
            while (true) //持续监听服务端发来的消息
            {
                int length = 0;
                byte[] buffer = new byte[SendBufferSize];
                try
                {
                    //将客户端套接字接收到的字节数组存入内存缓冲区, 并获取其长度
                    length = socketClient.Receive(buffer);
                }
                catch (SocketException ex)
                {
                    if (btnDisConnectToServer.Enabled==true)
                    {
                        btnConnectToServer.Enabled = true;
                        btnDisConnectToServer.Enabled = false;
                        gbxSiteSelect.Enabled = false;
                        gbxCommand.Enabled = false;
                        txtCMsg.Enabled = false;
                        btnCSend.Enabled = false;
                        txtMsg.AppendText("Socker error message:" + ex.Message + "\r\n");
                        txtMsg.AppendText("Server disconnect...\r\n");
                        break;
                    }
                    break;
                }
                catch (Exception ex)
                {
                    txtMsg.AppendText("System error message: " + ex.Message + "\r\n");
                    break;
                }
                //将套接字获取到的字节数组转换为人可以看懂的字符串
                strRecMsg = Encoding.UTF8.GetString(buffer, 0, length);

                //将文本框输入的信息附加到txtMsg中  并显示 谁,什么时间,换行,发送了什么信息 再换行
                //txtMsg.AppendText("Server " + GetCurrentTime() + " send:\r\n" + strRecMsg + "\r\n");
                //update on version 1.1
                txtMsg.AppendText("Server send:" + "    " + strRecMsg + "\r\n");
            }
        }

        /// <summary>
        /// 发送字符串信息到服务端的方法
        /// </summary>
        private void ClientSendMsg(string sendMsg, byte symbol)
        {
            byte[] arrClientMsg = Encoding.UTF8.GetBytes(sendMsg);
            socketClient.Send(arrClientMsg);
            //txtMsg.AppendText("Client:" + GetCurrentTime() + "\r\n" + sendMsg + "\r\n");

            ////if (sendMsg != "get-teststat;")
            ////{
            ////    count = 0;
            ////    txtMsg.AppendText("Client send: " + sendMsg + "\r\n");
            ////}
            ////else
            ////{
            ////    count++;
            ////}

            ////if (count ==1)
            //update on version 1.1
            //txtMsg.AppendText("Client send: "  + sendMsg + "\r\n");
            txtMsg.AppendText("Client send: " + GetCurrentTime() + "    " + sendMsg + "\r\n");
            ////实际发送的字节数组比实际输入的长度多1 用于存取标识符
            //byte[] arrClientSendMsg = new byte[arrClientMsg.Length + 1];
            //arrClientSendMsg[0] = symbol;  //在索引为0的位置上添加一个标识符
            //Buffer.BlockCopy(arrClientMsg, 0, arrClientSendMsg, 1, arrClientMsg.Length); 
            //socketClient.Send(arrClientSendMsg);
            //txtMsg.AppendText("Client:" + GetCurrentTime() + "\r\n" + sendMsg + "\r\n");
        }

        //向服务端发送信息
        private void btnCSend_Click(object sender, EventArgs e)
        {
            ClientSendMsg(txtCMsg.Text, 0);
        }

        //快捷键 Enter 发送信息
        private void txtCMsg_KeyDown(object sender, KeyEventArgs e)
        {   //当光标位于输入文本框上的情况下 发送信息的热键为回车键Enter 
            if (e.KeyCode == Keys.Enter)
            {
                //则调用客户端向服务端发送信息的方法
                ClientSendMsg(txtCMsg.Text, 0);
            }
        }

        /// <summary>
        /// 获取当前系统时间
        /// </summary>
        public String GetCurrentTime()
        {
            DateTime dt = DateTime.Now;
            string currentTime = dt.ToString("yyyy-MM-dd HH:mm:ss");
            return currentTime;

            //DateTime currentTime = new DateTime();
            //currentTime = DateTime.Now;
            //return currentTime;
        }

        private void AllOn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                checkedListBox1.SetItemChecked(i, true);
            //txtMsg.AppendText(listBox1.Items[i] +" Selected"+ "\r\n");
            }
            SiteIndex = 65535;
        }

        private void AllOff_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
                checkedListBox1.SetItemChecked(i, false);
            gbxCommand.Enabled = false;
            SiteIndex = 65535;
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SiteIndex = 0;
            gbxCommand.Enabled = true;
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                if ( checkedListBox1.GetItemChecked(i))
                {
                    SiteIndex = SiteIndex + (int)Math.Pow(2, i);
                }
            }
        }

        private void ResetBoard_Click(object sender, EventArgs e)
        {
            ClientSendMsg("reset-board;", 0);
            System.Threading.Thread.Sleep(10);
        }

        private void btnTestInit_Click(object sender, EventArgs e)
        {
            ClientSendMsg("testinit;", 0);
            System.Threading.Thread.Sleep(10);
        }

        private void btnSetVcc_Click(object sender, EventArgs e)
        {
            ClientSendMsg("set-vccvolt:" + nudSetVccVolt.Value + ";", 0);
            System.Threading.Thread.Sleep(10);
        }

        private void btnSetVio_Click(object sender, EventArgs e)
        {
            ClientSendMsg("set-viovolt:" + nudSetVioVolt.Value + ";", 0);
            System.Threading.Thread.Sleep(10);
        }

        private void btnSetClock_Click(object sender, EventArgs e)
        {
            ClientSendMsg("set-clock:" + nudSetClock.Value + ";", 0);
            System.Threading.Thread.Sleep(10);
        }

        private void btnGetChipID_Click(object sender, EventArgs e)
        {
            ClientSendMsg("get-chipid;", 0);
            System.Threading.Thread.Sleep(10);
        }


        //need to be change to value by site setting
        private void btnSetZone_Click(object sender, EventArgs e)
        {
            ClientSendMsg("set-zone:" + SiteIndex + ";", 0);
            System.Threading.Thread.Sleep(10);
        }

        private void btnSetPattern_Click(object sender, EventArgs e)
        {
            ClientSendMsg("set-pattern:" + nudSetPattern.Value + ";", 0);
            System.Threading.Thread.Sleep(10);
        }

        private void btnSetSample_Click(object sender, EventArgs e)
        {
            ClientSendMsg("set-sample:" + txtSetSample.Text + ";", 0);
            System.Threading.Thread.Sleep(10);
        }

        private void btnSetBlockNum_Click(object sender, EventArgs e)
        {
            ClientSendMsg("set-blocknum:" + nudSetBlockNumLow.Value + "," + nudSetBlockNumHigh.Value + ";", 0);
            System.Threading.Thread.Sleep(10);
        }

        private void btnSetEraseNum_Click(object sender, EventArgs e)
        {
            ClientSendMsg("set-erasenum:" + nudSetEraseNum.Value + ";", 0);
            System.Threading.Thread.Sleep(10);
        }

        private void btnSetBlockMaxETime_Click(object sender, EventArgs e)
        {
            ClientSendMsg("set-blockmaxetime:" + nudSetMaxETime.Value + ";", 0);
            System.Threading.Thread.Sleep(10);
        }

        private void btnSetAlg_Click(object sender, EventArgs e)
        {
            ClientSendMsg("set-alg:" + nudSetAlg.Value + ";", 0);
            System.Threading.Thread.Sleep(10);
        }

        private void btnSet4Byte_Click(object sender, EventArgs e)
        {
            ClientSendMsg("set-4byte;", 0);
            System.Threading.Thread.Sleep(10);
        }

        private void btnSetFast_Click(object sender, EventArgs e)
        {
            ClientSendMsg("set-fast;", 0);
            System.Threading.Thread.Sleep(10);
        }

        private void btnSetFast1_Click(object sender, EventArgs e)
        {
            ClientSendMsg("set-fast1;", 0);
            System.Threading.Thread.Sleep(10);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            ClientSendMsg("start;", 0);
            System.Threading.Thread.Sleep(10);
        }
        //update on version 1.1
        private void btnGetTestStart_Click(object sender, EventArgs e)
        {
            int i = 0;
            strRecMsg = null;
            if (nudLoopCount.Value>1)
            {
                while ((strRecMsg != "ok:1") & (i < nudLoopCount.Value))
                {
                    i++;
                    ClientSendMsg("get-teststat;", 0);
                    System.Threading.Thread.Sleep(Int32.Parse(nudInterval.Value.ToString()));
                }
            }
            else
            {
                ClientSendMsg("get-teststat;", 0);
            }

        }

        private void btnGetResult_Click(object sender, EventArgs e)
        {
            ClientSendMsg("get-result;", 0);
            System.Threading.Thread.Sleep(10);
        }

        private void btnClearLog_Click(object sender, EventArgs e)
        {
            txtMsg.Text = null;
        }

        private void btnSaveLog_Click(object sender, EventArgs e)
        {
            // Text from the rich textbox rtfMain
            string str = txtMsg.Text;
            // Create a new SaveFileDialog object
            using (SaveFileDialog dlgSave = new SaveFileDialog())
                try
                {
                    // Available file extensions
                    dlgSave.Filter = "Text Files (*.txt)|*.txt";
                    // SaveFileDialog title
                    dlgSave.Title = "Save";
                    // Show SaveFileDialog
                    if (dlgSave.ShowDialog() == DialogResult.OK && dlgSave.FileName.Length > 0)
                    {
                        // Save file as utf8 without byte order mark (BOM)
                        UTF8Encoding utf8 = new UTF8Encoding();
                        StreamWriter sw = new StreamWriter(dlgSave.FileName, false, utf8);
                        sw.Write(str);
                        sw.Close();
                    }
                }
                catch (Exception errorMsg)
                {
                    MessageBox.Show(errorMsg.Message);
                } 
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            tsslTime.Text = GetCurrentTime();
        }

    }
}
