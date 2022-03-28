using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace UDP_message
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        UdpClient U;
        Thread Th;

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "我的IP： " + MyIP();
        }

        private void Listen()
        {
            int port = int.Parse(txtport.Text);
            U = new UdpClient(port);     //建立UdpClient物件

            IPEndPoint EP = new IPEndPoint(IPAddress.Parse("127.0.0.1"), port);    //監聽本機電腦上的port號

            while (true)
            {
                byte[] B = U.Receive(ref EP);    //傳回由遠端主機傳送的 UDP 資料包
                receivemsg.Text = Encoding.Unicode.GetString(B);   //讀取資料包並將其轉為字串類型
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;   //忽略執行緒傳回的錯誤訊息
            Th =new Thread(Listen);   //建立執行緒物件
            Th.Start();   //執行緒開始
            button1.Enabled = false;   //不能重複開啟監聽
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
           
            try
            {

                if (Th != null)
                {
                    Th.Abort();   //關閉執行緒
                    U.Close();    //關閉監聽
                }
                
            }
            catch
            {
                
            }
        }

        private void btnsend_Click(object sender, EventArgs e)
        {
            string IP = txt_targetip.Text;
            int port = int.Parse(txt_targetport.Text);
            byte[] B = Encoding.Unicode.GetBytes(txt_targetmsg.Text);    //將文字轉乘bytes類型
            UdpClient S = new UdpClient();
            S.Send(B, B.Length, IP, port);
            S.Close();
        }

        private string MyIP()
        {
            string hostname = Dns.GetHostName();
            IPAddress[] IP = Dns.GetHostEntry(hostname).AddressList;     //取得所有本機ip位址
            foreach (IPAddress ip in IP)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork && ip.ToString() !="192.168.56.1")
                {
                    return ip.ToString();
                }
            }

            return "";
        }
    }
}
