namespace p4_chat
{
    partial class Popup
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
            this.buttonAdd = new System.Windows.Forms.Button();
            this.serverName = new System.Windows.Forms.TextBox();
            this.userName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.failLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(186, 262);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(129, 43);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "Connect";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // serverName
            // 
            this.serverName.Location = new System.Drawing.Point(61, 80);
            this.serverName.Name = "serverName";
            this.serverName.Size = new System.Drawing.Size(376, 26);
            this.serverName.TabIndex = 1;
            // 
            // userName
            // 
            this.userName.Location = new System.Drawing.Point(61, 167);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(376, 26);
            this.userName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter URL or IP address:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Enter Username:";
            // 
            // failLabel
            // 
            this.failLabel.AutoSize = true;
            this.failLabel.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.failLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.failLabel.ForeColor = System.Drawing.Color.Red;
            this.failLabel.Location = new System.Drawing.Point(167, 210);
            this.failLabel.Name = "failLabel";
            this.failLabel.Size = new System.Drawing.Size(170, 25);
            this.failLabel.TabIndex = 5;
            this.failLabel.Text = "Connection Failed";
            this.failLabel.Visible = false;
            // 
            // Popup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 357);
            this.Controls.Add(this.failLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.serverName);
            this.Controls.Add(this.buttonAdd);
            this.Name = "Popup";
            this.Text = "Enter info";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox serverName;
        private System.Windows.Forms.TextBox userName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label failLabel;
    }
}