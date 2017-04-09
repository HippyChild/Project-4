using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace p4_chat
{
    public partial class Form1 : Form
    {
        private TcpClient client;
        private StreamReader reader;
        private StreamWriter writer;
        private String textReceived;
        private String textToSend;

        private void Server()
        {
            TcpListener listener = new TcpListener(IPAddress.Any, 51111);
            listener.Start();
            client = listener.AcceptTcpClient();
            reader = new StreamReader(client.GetStream());
            writer = new StreamWriter(client.GetStream());
            writer.AutoFlush = true;

            backgroundWorker1.RunWorkerAsync();  // start receving data in the background
            while (true)
            {
                try
                {

                }catch(Exception e)
                {
                    Console.WriteLine("Error: " + e);
                    Console.ReadLine();
                }
            }
        }

        private void Client()
        {

        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Thread(Server).Start();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            while (client.Connected)
            {
                try
                {
                    textReceived = reader.ReadLine();
                    textReceivedTextBox.Invoke(new MethodInvoker(delegate ()
                    {
                        textReceivedTextBox.Clear();
                        textReceivedTextBox.AppendText(textReceived);
                    }));
                    textReceived = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {//join server button

            Popup pop = new Popup();
            pop.ShowDialog();
            //userName

        }

        private void textReceivedTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
