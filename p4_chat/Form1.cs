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
        private void Server()
        {
            TcpListener listener = new TcpListener(IPAddress.Any, 51111);
            listener.Start();
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

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Thread(Server).Start();
        }
    }
}
