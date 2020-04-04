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

namespace ChatApp
{
    public partial class Form1 : Form
    {
        Socket sck;
        EndPoint epLocal, epRemote;

        public Form1()
        {
            InitializeComponent();

            sck = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            sck.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);

            LocalIpTextBox.Text = GetLocalIp();
            FriendsIpTextBox.Text = "";
        }

        private string GetLocalIp()
        {
            IPHostEntry host;
            host = Dns.GetHostEntry(Dns.GetHostName());

            foreach(IPAddress ip in host.AddressList)
            {
                if(ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }

            return "127.0.0.1";
        }

        private void MessageCallBack(IAsyncResult asyncResult)
        {
            try
            {
                int size = sck.EndReceiveFrom(asyncResult, ref epRemote);

                if (size > 0)
                {
                    byte[] receivedData = new Byte[1464];
                    receivedData = (byte[])asyncResult.AsyncState;

                    ASCIIEncoding eEncoding = new ASCIIEncoding();
                    string receivedMessage = eEncoding.GetString(receivedData);

                    ListMessage.Items.Add("Friend: " + receivedMessage);
                }

                byte[] buffer = new byte[1500];
                sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallBack), buffer);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            try
            {
                epLocal = new IPEndPoint(IPAddress.Parse(LocalIpTextBox.Text), Convert.ToInt32(LocalPortTextBox.Text));
                sck.Bind(epLocal);

                epRemote = new IPEndPoint(IPAddress.Parse(FriendsIpTextBox.Text), Convert.ToInt32(FriendsPortTextBox.Text));
                sck.Connect(epRemote);

                byte[] buffer = new byte[1500];
                sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallBack), buffer);

                StartButton.Text = "Connected";
                StartButton.Enabled = false;
                SendButton.Enabled = true;

                MessageTextBox.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            try
            {
                System.Text.ASCIIEncoding enc = new System.Text.ASCIIEncoding();
                byte[] msg = new byte[1500];
                msg = enc.GetBytes(MessageTextBox.Text);

                sck.Send(msg);

                ListMessage.Items.Add("Me: " + MessageTextBox.Text);
                MessageTextBox.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
