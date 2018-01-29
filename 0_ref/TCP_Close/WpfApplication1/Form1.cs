using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Net;
using System.Net.Sockets;

namespace SocketBlockingInterrupt
{
    public partial class Form1 : Form
    {
        public SynchronizationContext synContext;

        public Form1()
        {
            InitializeComponent();
        }

        bool bIsExecute;
        TcpListener listener;//监听套接字


        void ListenThread()
        {
            IPAddress serverIPAddress = IPAddress.Parse("192.168.99.216");
            int serverPort = int.Parse("9000");
            IPEndPoint endpoint = new IPEndPoint(serverIPAddress, serverPort);


            listener = new TcpListener(endpoint);
            listener.Start();         //启动监听，非阻塞
            
            //synContext.Post(updateUI, "监听线程：正在监听中...");

            while (bIsExecute) //循环条件
            {
                byte[] recvBuff = new byte[512];

                //捕获异常，强行退出Accept阻塞
                try
                {
                    //synContext.Post(updateUI, "监听线程：Accept正在阻塞中...");

                    TcpClient client = listener.AcceptTcpClient();     // 等待连接（阻塞）
                    //synContext.Post(updateUI, "监听线程：收到连接请求，已退出Accept阻塞");

                    int recvByte = client.Client.Receive(recvBuff);// 建立连接

                    // 解析命令
                    byte[] buff = new byte[recvByte];
                    for (int i = 0; i < recvByte; i++) { buff[i] = recvBuff[i]; }
                    string exitByt = Encoding.ASCII.GetString(buff);
                    if (exitByt == "Exit")
                    {
                        //synContext.Post(updateUI, "监听线程：收到数据" + exitByt);
                        break;
                    }
                }
                catch (SocketException ex)
                {
                    //synContext.Post(updateUI, "监听线程：发生异常，Accept阻塞被强行退出：" + ex.Message);
                    break;
                }
            }
            //synContext.Post(updateUI, "监听线程：已成功退出监听");
        }

        private void Start_Click(object sender, EventArgs e)
        {
            bIsExecute = true; //建立循环条件


            //开启监听线程
            Thread t = new Thread(new ThreadStart(ListenThread));
            t.IsBackground = true;
            t.Start();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            bIsExecute = false; //此处拆除循环条件

            //方法1：直接停止监听套接字，引发异常从而强行使Accept退出阻塞。
            //---------------------------------------------
            if (listener != null)
            {
                listener.Stop();
            }
            //---------------------------------------------
        }

    }
}
