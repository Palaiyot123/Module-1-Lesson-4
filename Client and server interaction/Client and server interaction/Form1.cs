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
using System.IO;

namespace Client_and_server_interaction
{
    public partial class Form1 : Form
    {
        private TcpClient client;
        public StreamReader STR;
        public StreamWriter STW;
        public string receive;
        public string texttosend;
        public Form1()
        {
            InitializeComponent();
            IPAddress[] localip = Dns.GetHostAddresses(Dns.GetHostName());
            
            foreach(IPAddress address in localip)
            {
                if (address.AddressFamily == AddressFamily.InterNetwork)
                {
                    txtboxserverip.Text = address.ToString();
                }
            } 
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnstart_Click(object sender, EventArgs e)
        {
            TcpListener listener = new TcpListener(IPAddress.Any, int.Parse(txtboxserverport.Text));
            listener.Start();
            client = listener.AcceptTcpClient();
            STR = new StreamReader(client.GetStream());
            STW = new StreamWriter(client.GetStream());
            STW.AutoFlush = true;
            backgroundWorker1.RunWorkerAsync();
            backgroundWorker2.WorkerSupportsCancellation = true;

        }

        private void btnconnect_Click(object sender, EventArgs e)
        {
            client = new TcpClient();
            IPEndPoint Ipend = new IPEndPoint(IPAddress.Parse(txtboxcleintip.Text), int.Parse(txtboxportclient.Text));

            try
            {
                client.Connect(Ipend);
                if(client.Connected)
                {
                    txtboxchat.AppendText("Connected to Server\n");
                    STR = new StreamReader(client.GetStream());
                    STW = new StreamWriter(client.GetStream());
                    STW.AutoFlush = true;
                    backgroundWorker1.RunWorkerAsync();
                    backgroundWorker2.WorkerSupportsCancellation = true;
                    txtboxchat.AppendText(Environment.NewLine);
                }
            }
            catch(Exception er)
            {
                MessageBox.Show(er.Message.ToString());
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            while(client.Connected)
            {
                try
                {
                    receive = STR.ReadLine();
                    this.txtboxchat.Invoke(new MethodInvoker(delegate ()
                    {
                        txtboxchat.AppendText("\nYou: " + receive);
                        txtboxchat.AppendText(Environment.NewLine);
                    }
                    ));
                    receive = "";
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            if(client.Connected)
            {
                STW.WriteLine(texttosend);
                this.txtboxchat.Invoke(new MethodInvoker(delegate ()
                {
                    txtboxchat.AppendText("\nMe: " + texttosend);
                    txtboxchat.AppendText(Environment.NewLine);
                }
               ));                     
            }
            else
            {
                MessageBox.Show("Sending failed");
            }
            backgroundWorker2.CancelAsync();
        }

        private void btnsend_Click(object sender, EventArgs e)
        {
            if(txtmessagebox.Text!="")
            {
                texttosend = txtmessagebox.Text;
                backgroundWorker2.RunWorkerAsync();
                
            }
            txtmessagebox.Text = "";
        }
    }
}
