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

namespace Client2
{
    public partial class Form1 : Form
    {
        private TcpClient client;
        private StreamReader reader;
        private StreamWriter writer;
        private String textReceived;
        private String textToSend;

        //
        private String username;

        //server side
        private ArrayList usernames = new ArrayList();
        private ArrayList Readers = new ArrayList();
        private ArrayList Writers = new ArrayList();
        private int readerSocket = -1;

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e) {
            while (client.Connected) {
                try
                {

                    textReceived = reader.ReadLine();
                    textReceivedTextBox.Invoke(new MethodInvoker(delegate ()
                   {
                       textReceivedTextBox.AppendText(textReceived + Environment.NewLine);

                   }

                    ));
                    if (textReceived == "Username" + username + " taken,please try again.")
                    {
                        client.Close();
                    }
                    textReceived = "";
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                    client.Close();
                }
                chatPanel.Invoke(new MethodInvoker(delegate () {
                    chatPanel.Hide();
                }));
                }

            
        }

        public Form1()
        {
            InitializeComponent();
        }
    }
}
