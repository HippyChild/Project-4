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
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(278, 418);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 30);
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
            this.joinServer.Location = new System.Drawing.Point(278, 367);
            this.joinServer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.joinServer.Name = "joinServer";
            this.joinServer.Size = new System.Drawing.Size(116, 29);
            this.joinServer.TabIndex = 1;
            this.joinServer.Text = "join Server";
            this.joinServer.UseVisualStyleBackColor = true;
            this.joinServer.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(76, 293);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(546, 22);
            this.textBox1.TabIndex = 3;
            // 
            // textReceivedTextBox
            // 
            this.textReceivedTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textReceivedTextBox.Location = new System.Drawing.Point(76, 56);
            this.textReceivedTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textReceivedTextBox.Multiline = true;
            this.textReceivedTextBox.Name = "textReceivedTextBox";
            this.textReceivedTextBox.ReadOnly = true;
            this.textReceivedTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textReceivedTextBox.Size = new System.Drawing.Size(567, 177);
            this.textReceivedTextBox.TabIndex = 4;
            this.textReceivedTextBox.TextChanged += new System.EventHandler(this.textReceivedTextBox_TextChanged);
            // 
            // labelReceived
            // 
            this.labelReceived.AutoSize = true;
            this.labelReceived.Location = new System.Drawing.Point(73, 20);
            this.labelReceived.Name = "labelReceived";
            this.labelReceived.Size = new System.Drawing.Size(128, 17);
            this.labelReceived.TabIndex = 5;
            this.labelReceived.Text = "Message Received";
            // 
            // labelSent
            // 
            this.labelSent.AutoSize = true;
            this.labelSent.Location = new System.Drawing.Point(73, 262);
            this.labelSent.Name = "labelSent";
            this.labelSent.Size = new System.Drawing.Size(98, 17);
            this.labelSent.TabIndex = 6;
            this.labelSent.Text = "Message Sent";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 483);
            this.Controls.Add(this.labelSent);
            this.Controls.Add(this.labelReceived);
            this.Controls.Add(this.textReceivedTextBox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.joinServer);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button joinServer;
        private System.Windows.Forms.TextBox textBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox textReceivedTextBox;
        private System.Windows.Forms.Label labelReceived;
        private System.Windows.Forms.Label labelSent;
    }
}

