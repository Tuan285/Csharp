namespace RS485_ARDUINO
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxBaud = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxCom = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxSlave1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBoxSlave1 = new System.Windows.Forms.PictureBox();
            this.buttonSlave = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBoxSlave2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonSlave2 = new System.Windows.Forms.Button();
            this.pictureBoxSlave2 = new System.Windows.Forms.PictureBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBoxSlave3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonSlave3 = new System.Windows.Forms.Button();
            this.pictureBoxSlave3 = new System.Windows.Forms.PictureBox();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSlave1)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSlave2)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSlave3)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.buttonConnect);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboBoxBaud);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBoxCom);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(193, 417);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "COM";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "CONNECTED !";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RS485_ARDUINO.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(6, 235);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(176, 176);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // buttonConnect
            // 
            this.buttonConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConnect.Location = new System.Drawing.Point(11, 131);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(176, 37);
            this.buttonConnect.TabIndex = 4;
            this.buttonConnect.Text = "CONNECT";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "BAUD :";
            // 
            // comboBoxBaud
            // 
            this.comboBoxBaud.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxBaud.FormattingEnabled = true;
            this.comboBoxBaud.Location = new System.Drawing.Point(80, 79);
            this.comboBoxBaud.Name = "comboBoxBaud";
            this.comboBoxBaud.Size = new System.Drawing.Size(107, 28);
            this.comboBoxBaud.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "COM :";
            // 
            // comboBoxCom
            // 
            this.comboBoxCom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCom.FormattingEnabled = true;
            this.comboBoxCom.Location = new System.Drawing.Point(80, 34);
            this.comboBoxCom.Name = "comboBoxCom";
            this.comboBoxCom.Size = new System.Drawing.Size(107, 28);
            this.comboBoxCom.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxSlave1);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.pictureBoxSlave1);
            this.groupBox2.Controls.Add(this.buttonSlave);
            this.groupBox2.Location = new System.Drawing.Point(211, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(235, 135);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "SLAVE 1";
            // 
            // textBoxSlave1
            // 
            this.textBoxSlave1.Location = new System.Drawing.Point(138, 115);
            this.textBoxSlave1.Name = "textBoxSlave1";
            this.textBoxSlave1.Size = new System.Drawing.Size(80, 20);
            this.textBoxSlave1.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "DATA :";
            // 
            // pictureBoxSlave1
            // 
            this.pictureBoxSlave1.Image = global::RS485_ARDUINO.Properties.Resources.lightOFF;
            this.pictureBoxSlave1.Location = new System.Drawing.Point(136, 34);
            this.pictureBoxSlave1.Name = "pictureBoxSlave1";
            this.pictureBoxSlave1.Size = new System.Drawing.Size(80, 80);
            this.pictureBoxSlave1.TabIndex = 1;
            this.pictureBoxSlave1.TabStop = false;
            // 
            // buttonSlave
            // 
            this.buttonSlave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSlave.Location = new System.Drawing.Point(15, 34);
            this.buttonSlave.Name = "buttonSlave";
            this.buttonSlave.Size = new System.Drawing.Size(80, 80);
            this.buttonSlave.TabIndex = 0;
            this.buttonSlave.Text = "ON";
            this.buttonSlave.UseVisualStyleBackColor = true;
            this.buttonSlave.Click += new System.EventHandler(this.buttonSlave_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBoxSlave2);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.buttonSlave2);
            this.groupBox3.Controls.Add(this.pictureBoxSlave2);
            this.groupBox3.Location = new System.Drawing.Point(211, 153);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(235, 135);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "SLAVE 2";
            // 
            // textBoxSlave2
            // 
            this.textBoxSlave2.Location = new System.Drawing.Point(138, 109);
            this.textBoxSlave2.Name = "textBoxSlave2";
            this.textBoxSlave2.Size = new System.Drawing.Size(80, 20);
            this.textBoxSlave2.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "DATA :";
            // 
            // buttonSlave2
            // 
            this.buttonSlave2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSlave2.Location = new System.Drawing.Point(15, 27);
            this.buttonSlave2.Name = "buttonSlave2";
            this.buttonSlave2.Size = new System.Drawing.Size(80, 80);
            this.buttonSlave2.TabIndex = 4;
            this.buttonSlave2.Text = "ON";
            this.buttonSlave2.UseVisualStyleBackColor = true;
            this.buttonSlave2.Click += new System.EventHandler(this.buttonSlave2_Click);
            // 
            // pictureBoxSlave2
            // 
            this.pictureBoxSlave2.Image = global::RS485_ARDUINO.Properties.Resources.lightOFF;
            this.pictureBoxSlave2.Location = new System.Drawing.Point(136, 27);
            this.pictureBoxSlave2.Name = "pictureBoxSlave2";
            this.pictureBoxSlave2.Size = new System.Drawing.Size(80, 80);
            this.pictureBoxSlave2.TabIndex = 3;
            this.pictureBoxSlave2.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBoxSlave3);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.buttonSlave3);
            this.groupBox4.Controls.Add(this.pictureBoxSlave3);
            this.groupBox4.Location = new System.Drawing.Point(211, 294);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(235, 135);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "SLAVE 3";
            // 
            // textBoxSlave3
            // 
            this.textBoxSlave3.Location = new System.Drawing.Point(136, 109);
            this.textBoxSlave3.Name = "textBoxSlave3";
            this.textBoxSlave3.Size = new System.Drawing.Size(80, 20);
            this.textBoxSlave3.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "DATA :";
            // 
            // buttonSlave3
            // 
            this.buttonSlave3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSlave3.Location = new System.Drawing.Point(15, 27);
            this.buttonSlave3.Name = "buttonSlave3";
            this.buttonSlave3.Size = new System.Drawing.Size(80, 80);
            this.buttonSlave3.TabIndex = 5;
            this.buttonSlave3.Text = "ON";
            this.buttonSlave3.UseVisualStyleBackColor = true;
            this.buttonSlave3.Click += new System.EventHandler(this.buttonSlave3_Click);
            // 
            // pictureBoxSlave3
            // 
            this.pictureBoxSlave3.Image = global::RS485_ARDUINO.Properties.Resources.lightOFF;
            this.pictureBoxSlave3.Location = new System.Drawing.Point(136, 27);
            this.pictureBoxSlave3.Name = "pictureBoxSlave3";
            this.pictureBoxSlave3.Size = new System.Drawing.Size(80, 80);
            this.pictureBoxSlave3.TabIndex = 4;
            this.pictureBoxSlave3.TabStop = false;
            // 
            // serialPort
            // 
            this.serialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort_DataReceived);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 432);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSlave1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSlave2)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSlave3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxBaud;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxCom;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.Button buttonSlave;
        private System.Windows.Forms.PictureBox pictureBoxSlave1;
        private System.Windows.Forms.PictureBox pictureBoxSlave2;
        private System.Windows.Forms.PictureBox pictureBoxSlave3;
        private System.Windows.Forms.Button buttonSlave2;
        private System.Windows.Forms.Button buttonSlave3;
        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxSlave2;
        private System.Windows.Forms.TextBox textBoxSlave1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxSlave3;
        private System.Windows.Forms.Label label6;
    }
}

