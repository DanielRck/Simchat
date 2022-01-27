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
using System.Diagnostics;

namespace SimChat
{
    public partial class Form1 : Form
    {
        Socket sck;
        EndPoint epLocal, epRemote;
        byte[] buffer;

        public object FontDialog1 { get; private set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //set up socket
            sck = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);

            sck.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);

            // get user IP
            textLocalIp.Text = GetLocalIP();
            textRemoteIp.Text = GetLocalIP();
        }

        private string GetLocalIP()
        {
            IPHostEntry host;
            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                    return ip.ToString();
            }
            return "127.0.0.1";
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            //binding Socket
            epLocal = new IPEndPoint(IPAddress.Parse(textLocalIp.Text), Convert.ToInt32(textLocalPort.Text));
            sck.Bind(epLocal);
            //Connecting to remote IP
            epRemote = new IPEndPoint(IPAddress.Parse(textRemoteIp.Text), Convert.ToInt32(textRemotePort.Text));
            sck.Connect(epRemote);
            //Listening the specific port
            buffer = new byte[1500];
            sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallBack), buffer);

         
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            //Convert string message to byte[]
            ASCIIEncoding aEncoding = new ASCIIEncoding();
            byte[] sendingMessage = new byte[1500];
            sendingMessage = aEncoding.GetBytes(textMessage.Text);
            //Sending the Encoded message
            sck.Send(sendingMessage);
            //addding to the listbox
            listMessage.Items.Add("Me: " + textMessage.Text);
            textMessage.Text = "";

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo("http://simchat.it/");
            Process.Start(sInfo);
        }

        // to exit and close simchat//
        private void exitToolStripMenuItem_Click1(object sender, EventArgs e)
        {
            Close();
        }

        private void supportToolStripMenuItem_Click1(object sender, EventArgs e)
        {
            string command = "mailto:daniel.rockenschaub[@]outlook.com?subject=The Subject&bcc=daniel.rockenschaub[at]outlook.com";
            Process.Start(command);
            Process.Start("mailto:daniel.rockenschaub@outlook.com");
        }
        // to select all the text in the text field //
        private void selectAllToolStripMenuItem_Click1(object sender, EventArgs e)
        {
            textMessage.SelectAll();
        }
        // to copy some data in the textbox //
        private void copyToolStripMenuItem_Click1(object sender, EventArgs e)
        {
            textMessage.Copy();
        }
        // to cut some data from the textbox //
        private void cutToolStripMenuItem_Click1(object sender, EventArgs e)
        {
            textMessage.Cut();
        }
        // to paste some copied data//
        private void pasteToolStripMenuItem_Click1(object sender, EventArgs e)
        {
            textMessage.Paste();
        }
        // to display date and time //
        private void dateTimeToolStripMenuItem_Click(object sender, EventArgs e)
        { 
            textMessage.Text = System.DateTime.Now.ToString();
        }

        private void labelConnected_Click(object sender, EventArgs e)
        {
            
        }

        private void styleToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void MessageCallBack(IAsyncResult aResult)
        {
            try
            {
                byte[] receivedData = new byte[1500];
                receivedData = (byte[])aResult.AsyncState;
                //Converting byte[] to string
                ASCIIEncoding aEncoding = new ASCIIEncoding();
                string receivedMessage = aEncoding.GetString(receivedData);

                //Adding this message into Listbox
                listMessage.Items.Add("Friend: " + receivedMessage);

                buffer = new byte[1500];
                sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallBack), buffer);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
     
    }
}
