using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace udpSocketClient
{
    public partial class Form1 : Form
    {
        private Socket m_socket; 
        private Thread m_receiveThread;


        public Form1()
        {
            InitializeComponent();
        }

        private void TXT_IP_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TXT_IP.Focus();
            Log("클라이언트 로드됨!!");
        }

        private void Log(string msg)
        {
            if (this.LST_LOG.InvokeRequired == true)
            {
                this.LST_LOG.Invoke((MethodInvoker)delegate
                {
                    this.LST_LOG.Items.Add(string.Format("[{0}]{1}", DateTime.Now.ToString(), msg));
                });
            }
            else
            {
                this.LST_LOG.Items.Add(string.Format("[{0}]{1}", DateTime.Now.ToString(), msg));
            }
        }

        private void BTN_CONNECT_Click(object sender, EventArgs e)
        {
            IPAddress ipaddress = IPAddress.Parse(TXT_IP.Text);
            IPEndPoint endPoint = new IPEndPoint(ipaddress, int.Parse(TXT_PORT.Text));

            m_socket = new Socket(
                AddressFamily.InterNetwork,
                SocketType.Stream,
                ProtocolType.Tcp
                );

            Log("서버에 연결 시도중...");

            
            m_socket.Connect(endPoint);
            Log("서버에 접속됨");

            m_receiveThread = new Thread(new ThreadStart(Receive));
            m_receiveThread.IsBackground = true;
            m_receiveThread.Start();
        }

        private void Receive()
        {
            while (true)
            {
                byte[] receiveBuffer = new byte[512];
                int length = m_socket.Receive(receiveBuffer, receiveBuffer.Length, SocketFlags.None);

                if (0 == length)
                {
                    m_socket.Disconnect(true);
                    m_socket.Close();
                }
                string msg = Encoding.UTF8.GetString(receiveBuffer, 0, length);
                ShowMsg("상대]" + msg);
            }
        }

        private void TXT_CHAT_KeyDown(object sender, KeyEventArgs e)
        {
            if (TXT_CHAT.Text.Trim() != "" && e.KeyCode == Keys.Enter)
            {
                byte[] sendBuffer = Encoding.UTF8.GetBytes(TXT_CHAT.Text.Trim());
                m_socket.Send(sendBuffer);
                Log("메시지 전송됨");
                ShowMsg("나]" + TXT_CHAT.Text);
                TXT_CHAT.Text = "";
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Log("close socket");
                byte[] sendBuffer = Encoding.UTF8.GetBytes("close socket");
                m_socket.Send(sendBuffer);
                m_socket.Disconnect(true);
                m_socket.Close();
            }
        }

        private void ShowMsg(string msg)
        {
            if (RTB_HISTORY.InvokeRequired == true)
            {
                RTB_HISTORY.Invoke((MethodInvoker)delegate
                {
                    RTB_HISTORY.AppendText(msg);
                    RTB_HISTORY.AppendText("\r\n");

                    this.Activate();
                    RTB_HISTORY.Focus();

                    RTB_HISTORY.SelectionStart = RTB_HISTORY.Text.Length;
                    RTB_HISTORY.ScrollToCaret();
                });
            }
            else
            {
                RTB_HISTORY.AppendText(msg);
                RTB_HISTORY.AppendText("\r\n");

                this.Activate();
                RTB_HISTORY.Focus();

                RTB_HISTORY.SelectionStart = RTB_HISTORY.Text.Length;
                RTB_HISTORY.ScrollToCaret();
            }
        }
    }
}
