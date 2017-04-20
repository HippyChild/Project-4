namespace p4_chat
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.joinServer = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textReceivedTextBox = new System.Windows.Forms.TextBox();
            this.labelReceived = new System.Windows.Forms.Label();
            this.labelSent = new System.Windows.Forms.Label();
            this.send = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.failLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.userName = new System.Windows.Forms.TextBox();
            this.serverName = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cancel = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(57, 53);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 24);
            this.button1.TabIndex = 0;
            this.button1.Text = "Host Server";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // joinServer
            // 
            this.joinServer.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.joinServer.Location = new System.Drawing.Point(57, 11);
            this.joinServer.Margin = new System.Windows.Forms.Padding(2);
            this.joinServer.Name = "joinServer";
            this.joinServer.Size = new System.Drawing.Size(87, 24);
            this.joinServer.TabIndex = 1;
            this.joinServer.Text = "Join Server";
            this.joinServer.UseVisualStyleBackColor = true;
            this.joinServer.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(38, 222);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(362, 20);
            this.textBox1.TabIndex = 3;
            // 
            // textReceivedTextBox
            // 
            this.textReceivedTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textReceivedTextBox.Location = new System.Drawing.Point(38, 30);
            this.textReceivedTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.textReceivedTextBox.Multiline = true;
            this.textReceivedTextBox.Name = "textReceivedTextBox";
            this.textReceivedTextBox.ReadOnly = true;
            this.textReceivedTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textReceivedTextBox.Size = new System.Drawing.Size(426, 145);
            this.textReceivedTextBox.TabIndex = 4;
            // 
            // labelReceived
            // 
            this.labelReceived.AutoSize = true;
            this.labelReceived.Location = new System.Drawing.Point(36, 0);
            this.labelReceived.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelReceived.Name = "labelReceived";
            this.labelReceived.Size = new System.Drawing.Size(99, 13);
            this.labelReceived.TabIndex = 5;
            this.labelReceived.Text = "Message Received";
            // 
            // labelSent
            // 
            this.labelSent.AutoSize = true;
            this.labelSent.Location = new System.Drawing.Point(36, 197);
            this.labelSent.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSent.Name = "labelSent";
            this.labelSent.Size = new System.Drawing.Size(75, 13);
            this.labelSent.TabIndex = 6;
            this.labelSent.Text = "Message Sent";
            // 
            // send
            // 
            this.send.Enabled = false;
            this.send.Location = new System.Drawing.Point(405, 220);
            this.send.Name = "send";
            this.send.Size = new System.Drawing.Size(59, 23);
            this.send.TabIndex = 7;
            this.send.Text = "Send";
            this.send.UseVisualStyleBackColor = true;
            this.send.Click += new System.EventHandler(this.send_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.send);
            this.panel1.Controls.Add(this.labelSent);
            this.panel1.Controls.Add(this.labelReceived);
            this.panel1.Controls.Add(this.textReceivedTextBox);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Location = new System.Drawing.Point(19, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(507, 257);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.joinServer);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(19, 279);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(203, 97);
            this.panel2.TabIndex = 9;
            // 
            // failLabel
            // 
            this.failLabel.AutoSize = true;
            this.failLabel.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.failLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.failLabel.ForeColor = System.Drawing.Color.Red;
            this.failLabel.Location = new System.Drawing.Point(77, 132);
            this.failLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.failLabel.Name = "failLabel";
            this.failLabel.Size = new System.Drawing.Size(121, 17);
            this.failLabel.TabIndex = 15;
            this.failLabel.Text = "Connection Failed";
            this.failLabel.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 82);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Enter Username:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Enter URL or IP address:";
            // 
            // userName
            // 
            this.userName.Location = new System.Drawing.Point(7, 105);
            this.userName.Margin = new System.Windows.Forms.Padding(2);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(252, 20);
            this.userName.TabIndex = 12;
            // 
            // serverName
            // 
            this.serverName.Location = new System.Drawing.Point(7, 48);
            this.serverName.Margin = new System.Windows.Forms.Padding(2);
            this.serverName.Name = "serverName";
            this.serverName.Size = new System.Drawing.Size(252, 20);
            this.serverName.TabIndex = 11;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(90, 166);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(86, 28);
            this.buttonAdd.TabIndex = 10;
            this.buttonAdd.Text = "Connect";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cancel);
            this.panel3.Controls.Add(this.failLabel);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.userName);
            this.panel3.Controls.Add(this.serverName);
            this.panel3.Controls.Add(this.buttonAdd);
            this.panel3.Location = new System.Drawing.Point(251, 279);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(275, 238);
            this.panel3.TabIndex = 16;
            this.panel3.Visible = false;
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(90, 199);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(86, 27);
            this.cancel.TabIndex = 16;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 521);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button joinServer;
        private System.Windows.Forms.TextBox textBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox textReceivedTextBox;
        private System.Windows.Forms.Label labelReceived;
        private System.Windows.Forms.Label labelSent;
        private System.Windows.Forms.Button send;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label failLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox userName;
        private System.Windows.Forms.TextBox serverName;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button cancel;
    }
}

