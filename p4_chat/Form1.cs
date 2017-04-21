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
using System.Threading;
using System.Collections;

namespace p4_chat
{
    public partial class Form1 : Form
    {
        private TcpClient client;
        private StreamReader reader;
        private StreamWriter writer;
        private String textReceived;
        private String textToSend;
        private String username;                            // Username for Client
        private ArrayList usernames = new ArrayList();      // Serverside list of usernames
        private ArrayList Readers = new ArrayList();
        private ArrayList Writers = new ArrayList();
        private int readerSocket = -1;
        /*
         * Client side doWork
         */
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            while (client.Connected)
            {
                try
                {
                    textReceived = reader.ReadLine();
                    textReceivedTextBox.Invoke(new MethodInvoker(delegate ()
                    {
                        textReceivedTextBox.AppendText(textReceived + Environment.NewLine);
                    }));
                    if(textReceived == "Username " + username + " taken, please try again.")
                    {
                        client.Close();
                    }
                    textReceived = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    client.Close();
                }
            }
            chatPanel.Invoke(new MethodInvoker(delegate ()
            {
                chatPanel.Hide();
            }));
            panel2.Invoke(new MethodInvoker(delegate ()
            {
                panel2.Show();
            }));
        }

        /*
         * Server side doWork
         */ 
        private void serverReader()
        {
            var sock = readerSocket;
            var readerServer = (StreamReader)Readers[sock];
            while (client.Connected)
            {
                try
                {
                    
                    textReceived = readerServer.ReadLine();
                    dataSenderServer(textReceived);
                    textReceived = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("User " + usernames[sock] + " has disconnected from the chat.");
                    client.Close();
                }
            }
            if (readerSocket >= sock)
            {
                readerSocket--;
                usernames.RemoveAt(sock);
                Readers.RemoveAt(sock);
                Writers.RemoveAt(sock);
            }
            else
            {
                var temp = sock - readerSocket;
                temp = sock - temp;
                readerSocket--;
                usernames.RemoveAt(temp);
                Readers.RemoveAt(temp);
                Writers.RemoveAt(temp);
            }
        }

        private void Server()
        {
            chatPanel.Hide();
            send.Visible = false;
            labelSent.Visible = false;
            panel2.Hide();
            TcpListener listener = new TcpListener(IPAddress.Any, 51111);
            listener.Start();
            var nameTaken = false;
            textReceivedTextBox.AppendText("Server started, awaiting connections..." + Environment.NewLine);
            while (true)
            {
                client = listener.AcceptTcpClient();

                reader = new StreamReader(client.GetStream());
                writer = new StreamWriter(client.GetStream());
                writer.AutoFlush = true;
                Readers.Add(reader);
                Writers.Add(writer);
                try
                {
                    textReceived = reader.ReadLine();
                    for (var i = 0; i < usernames.Count; i++)
                    {
                        if (usernames.Contains(textReceived))
                        {
                            dataSender("Username " + textReceived + " taken, please try again.");
                            textReceivedTextBox.AppendText("Error: connection received, username " + textReceived + " already taken" + Environment.NewLine);
                            nameTaken = true;
                            Readers.RemoveAt(Readers.Count - 1);
                            Writers.RemoveAt(Writers.Count - 1);
                            break;
                        }
                    }
                    if (!nameTaken)
                    {
                        usernames.Add(textReceived);
                        textReceivedTextBox.AppendText("Connection received from user " + textReceived + Environment.NewLine);
                        textReceived = "";
                        readerSocket++;
                        Task.Factory.StartNew(() => serverReader());// start recieving data in the background
                    }
                    else
                    {
                        client.Close();
                        nameTaken = false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private async void dataSenderServer(String toSend)
        {
            for(var i = 0; i <Writers.Count; i++)
            {
                writer = (StreamWriter)Writers[i];
                await writer.WriteLineAsync(toSend);
            }
        }

        private void Client(String ip)
        {
            ip = ip.Trim();
            client = new TcpClient();
            IPEndPoint IpEnd = new IPEndPoint(IPAddress.Parse(ip), 51111);

            try
            {
                client.Connect(IpEnd);
                if (client.Connected)
                {
                    send.Enabled = true;
                    chatPanel.Show();
                    panel1.Show();
                    panel3.Hide();
                    textReceivedTextBox.AppendText("Connected to Server!" + Environment.NewLine);

                    writer = new StreamWriter(client.GetStream());
                    reader = new StreamReader(client.GetStream());
                    writer.AutoFlush = true;

                    dataSender(userName.Text);

                    backgroundWorker1.RunWorkerAsync();  // start receiving data in the background
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void dataSender(String toSend)
        {
            await writer.WriteLineAsync(toSend);
        }

        /*
         * Form controls start here!
         */
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Server();
        }

        private void button2_Click(object sender, EventArgs e)
        {//join server button
            panel2.Hide();
            panel3.Show();
        }

        private void send_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                textToSend = username + ": " + textBox1.Text;
                if (textToSend != null)
                    dataSender(textToSend);
            }
            textBox1.Text = "";
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            //127.0.0.1
            if (serverName.Text == "" || userName.Text == "")
            {
                failLabel.Visible = true;
            }
            else
            {
                username = userName.Text;
                Client(serverName.Text);
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            panel2.Show();
            panel3.Hide();
        }
    }
}
