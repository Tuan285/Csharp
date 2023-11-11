namespace Arduino_Com
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_send_receive = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_receive = new System.Windows.Forms.TextBox();
            this.textBox_send = new System.Windows.Forms.TextBox();
            this.BT_send = new System.Windows.Forms.Button();
            this.stt = new System.Windows.Forms.Label();
            this.status = new System.Windows.Forms.Label();
            this.comboBox_Baud = new System.Windows.Forms.ComboBox();
            this.BT_DISC = new System.Windows.Forms.Button();
            this.BT_CONNECT = new System.Windows.Forms.Button();
            this.comboBox_Ports = new System.Windows.Forms.ComboBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel_send_receive.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel_send_receive);
            this.panel1.Controls.Add(this.comboBox_Baud);
            this.panel1.Controls.Add(this.BT_DISC);
            this.panel1.Controls.Add(this.BT_CONNECT);
            this.panel1.Controls.Add(this.comboBox_Ports);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(252, 254);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel_send_receive
            // 
            this.panel_send_receive.Controls.Add(this.button1);
            this.panel_send_receive.Controls.Add(this.label1);
            this.panel_send_receive.Controls.Add(this.textBox_receive);
            this.panel_send_receive.Controls.Add(this.textBox_send);
            this.panel_send_receive.Controls.Add(this.BT_send);
            this.panel_send_receive.Controls.Add(this.stt);
            this.panel_send_receive.Controls.Add(this.status);
            this.panel_send_receive.Location = new System.Drawing.Point(0, 97);
            this.panel_send_receive.Name = "panel_send_receive";
            this.panel_send_receive.Size = new System.Drawing.Size(252, 162);
            this.panel_send_receive.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(14, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Data Receive";
            // 
            // textBox_receive
            // 
            this.textBox_receive.Location = new System.Drawing.Point(18, 88);
            this.textBox_receive.Name = "textBox_receive";
            this.textBox_receive.Size = new System.Drawing.Size(221, 20);
            this.textBox_receive.TabIndex = 18;
            // 
            // textBox_send
            // 
            this.textBox_send.Location = new System.Drawing.Point(18, 3);
            this.textBox_send.Name = "textBox_send";
            this.textBox_send.Size = new System.Drawing.Size(101, 20);
            this.textBox_send.TabIndex = 17;
            this.textBox_send.TextChanged += new System.EventHandler(this.textBox_send_TextChanged);
            // 
            // BT_send
            // 
            this.BT_send.Location = new System.Drawing.Point(138, 3);
            this.BT_send.Name = "BT_send";
            this.BT_send.Size = new System.Drawing.Size(101, 28);
            this.BT_send.TabIndex = 16;
            this.BT_send.Text = "SEND";
            this.BT_send.UseVisualStyleBackColor = true;
            this.BT_send.Click += new System.EventHandler(this.BT_send_Click);
            // 
            // stt
            // 
            this.stt.AutoSize = true;
            this.stt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.stt.Location = new System.Drawing.Point(71, 125);
            this.stt.Name = "stt";
            this.stt.Size = new System.Drawing.Size(93, 20);
            this.stt.TabIndex = 15;
            this.stt.Text = "No Connect";
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.status.Location = new System.Drawing.Point(14, 125);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(64, 20);
            this.status.TabIndex = 14;
            this.status.Text = "Status :";
            // 
            // comboBox_Baud
            // 
            this.comboBox_Baud.FormattingEnabled = true;
            this.comboBox_Baud.Location = new System.Drawing.Point(134, 12);
            this.comboBox_Baud.Name = "comboBox_Baud";
            this.comboBox_Baud.Size = new System.Drawing.Size(101, 21);
            this.comboBox_Baud.TabIndex = 6;
            // 
            // BT_DISC
            // 
            this.BT_DISC.Location = new System.Drawing.Point(134, 57);
            this.BT_DISC.Name = "BT_DISC";
            this.BT_DISC.Size = new System.Drawing.Size(101, 34);
            this.BT_DISC.TabIndex = 5;
            this.BT_DISC.Text = "DISCONNECT";
            this.BT_DISC.UseVisualStyleBackColor = true;
            this.BT_DISC.Click += new System.EventHandler(this.BT_DISC_Click);
            // 
            // BT_CONNECT
            // 
            this.BT_CONNECT.Location = new System.Drawing.Point(14, 57);
            this.BT_CONNECT.Name = "BT_CONNECT";
            this.BT_CONNECT.Size = new System.Drawing.Size(101, 34);
            this.BT_CONNECT.TabIndex = 4;
            this.BT_CONNECT.Text = "CONNECT";
            this.BT_CONNECT.UseVisualStyleBackColor = true;
            this.BT_CONNECT.Click += new System.EventHandler(this.BT_CONNECT_Click);
            // 
            // comboBox_Ports
            // 
            this.comboBox_Ports.FormattingEnabled = true;
            this.comboBox_Ports.Location = new System.Drawing.Point(14, 12);
            this.comboBox_Ports.Name = "comboBox_Ports";
            this.comboBox_Ports.Size = new System.Drawing.Size(101, 21);
            this.comboBox_Ports.TabIndex = 3;
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(138, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 28);
            this.button1.TabIndex = 20;
            this.button1.Text = "CLEAR";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 278);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel_send_receive.ResumeLayout(false);
            this.panel_send_receive.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BT_DISC;
        private System.Windows.Forms.Button BT_CONNECT;
        private System.Windows.Forms.ComboBox comboBox_Ports;
        private System.Windows.Forms.ComboBox comboBox_Baud;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Panel panel_send_receive;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_receive;
        private System.Windows.Forms.TextBox textBox_send;
        private System.Windows.Forms.Button BT_send;
        private System.Windows.Forms.Label stt;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.Button button1;
    }
}

