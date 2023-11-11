namespace Ard_Blink_Led_Com
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbPort = new System.Windows.Forms.Label();
            this.cbPort = new System.Windows.Forms.ComboBox();
            this.cbBaud = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btConnect = new System.Windows.Forms.Button();
            this.btOn = new System.Windows.Forms.Button();
            this.btOff = new System.Windows.Forms.Button();
            this.btDisconnect = new System.Windows.Forms.Button();
            this.lbtrangThai = new System.Windows.Forms.Label();
            this.trangThai = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(14, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(449, 242);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.trangThai);
            this.panel2.Controls.Add(this.lbtrangThai);
            this.panel2.Controls.Add(this.btDisconnect);
            this.panel2.Controls.Add(this.btConnect);
            this.panel2.Controls.Add(this.cbBaud);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.cbPort);
            this.panel2.Controls.Add(this.lbPort);
            this.panel2.Location = new System.Drawing.Point(13, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(429, 115);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btOff);
            this.panel3.Controls.Add(this.btOn);
            this.panel3.Location = new System.Drawing.Point(14, 141);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(428, 89);
            this.panel3.TabIndex = 1;
            // 
            // lbPort
            // 
            this.lbPort.AutoSize = true;
            this.lbPort.Location = new System.Drawing.Point(36, 22);
            this.lbPort.Name = "lbPort";
            this.lbPort.Size = new System.Drawing.Size(37, 13);
            this.lbPort.TabIndex = 0;
            this.lbPort.Text = "PORT";
            // 
            // cbPort
            // 
            this.cbPort.FormattingEnabled = true;
            this.cbPort.Location = new System.Drawing.Point(100, 19);
            this.cbPort.Name = "cbPort";
            this.cbPort.Size = new System.Drawing.Size(115, 21);
            this.cbPort.TabIndex = 1;
            // 
            // cbBaud
            // 
            this.cbBaud.FormattingEnabled = true;
            this.cbBaud.Location = new System.Drawing.Point(100, 46);
            this.cbBaud.Name = "cbBaud";
            this.cbBaud.Size = new System.Drawing.Size(115, 21);
            this.cbBaud.TabIndex = 3;
            this.cbBaud.Text = "9600";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "BAUD";
            // 
            // btConnect
            // 
            this.btConnect.Location = new System.Drawing.Point(221, 19);
            this.btConnect.Name = "btConnect";
            this.btConnect.Size = new System.Drawing.Size(89, 48);
            this.btConnect.TabIndex = 4;
            this.btConnect.Text = "Connect";
            this.btConnect.UseVisualStyleBackColor = true;
            this.btConnect.Click += new System.EventHandler(this.btConnect_Click);
            // 
            // btOn
            // 
            this.btOn.Location = new System.Drawing.Point(220, 23);
            this.btOn.Name = "btOn";
            this.btOn.Size = new System.Drawing.Size(89, 48);
            this.btOn.TabIndex = 5;
            this.btOn.Text = "Bat";
            this.btOn.UseVisualStyleBackColor = true;
            this.btOn.Click += new System.EventHandler(this.btOn_Click);
            // 
            // btOff
            // 
            this.btOff.Location = new System.Drawing.Point(315, 23);
            this.btOff.Name = "btOff";
            this.btOff.Size = new System.Drawing.Size(89, 48);
            this.btOff.TabIndex = 6;
            this.btOff.Text = "Tat";
            this.btOff.UseVisualStyleBackColor = true;
            this.btOff.Click += new System.EventHandler(this.btOff_Click);
            // 
            // btDisconnect
            // 
            this.btDisconnect.Location = new System.Drawing.Point(316, 19);
            this.btDisconnect.Name = "btDisconnect";
            this.btDisconnect.Size = new System.Drawing.Size(89, 48);
            this.btDisconnect.TabIndex = 5;
            this.btDisconnect.Text = "Disconnect";
            this.btDisconnect.UseVisualStyleBackColor = true;
            this.btDisconnect.Click += new System.EventHandler(this.btDisconnect_Click);
            // 
            // lbtrangThai
            // 
            this.lbtrangThai.AutoSize = true;
            this.lbtrangThai.Location = new System.Drawing.Point(36, 88);
            this.lbtrangThai.Name = "lbtrangThai";
            this.lbtrangThai.Size = new System.Drawing.Size(65, 13);
            this.lbtrangThai.TabIndex = 6;
            this.lbtrangThai.Text = "Trang Thai :";
            // 
            // trangThai
            // 
            this.trangThai.AutoSize = true;
            this.trangThai.Location = new System.Drawing.Point(108, 88);
            this.trangThai.Name = "trangThai";
            this.trangThai.Size = new System.Drawing.Size(73, 13);
            this.trangThai.TabIndex = 7;
            this.trangThai.Text = "Chua ket noi !";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 265);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btOff;
        private System.Windows.Forms.Button btOn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btConnect;
        private System.Windows.Forms.ComboBox cbBaud;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbPort;
        private System.Windows.Forms.Label lbPort;
        private System.Windows.Forms.Button btDisconnect;
        private System.Windows.Forms.Label trangThai;
        private System.Windows.Forms.Label lbtrangThai;
    }
}

