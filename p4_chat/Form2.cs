using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace p4_chat
{
    public partial class Popup : Form
    {
        public Popup()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            //127.0.0.1
            if (serverName.Text == "" || userName.Text == "")
            {
                failLabel.Visible = true;
            }
            else {

                failLabel.Visible = false;
            }


        }
    }
}
