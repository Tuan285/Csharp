namespace MPU6050_ARDUINO_CSHARP
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
            this.STATUS_COM = new System.Windows.Forms.Label();
            this.BT_DISC = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BT_CONNECT = new System.Windows.Forms.Button();
            this.comboBox_BAUD = new System.Windows.Forms.ComboBox();
            this.comboBox_COM = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label_value_x = new System.Windows.Forms.Label();
            this.WARNING_X = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CONFIRM_X = new System.Windows.Forms.Button();
            this.textBox_MAX_X = new System.Windows.Forms.TextBox();
            this.textBox_MINX = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label_value_z = new System.Windows.Forms.Label();
            this.WARNING_Z = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.CONFIRM_Z = new System.Windows.Forms.Button();
            this.textBox_MAX_Z = new System.Windows.Forms.TextBox();
            this.textBox_MINZ = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_value_y = new System.Windows.Forms.Label();
            this.WARNING_Y = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CONFIRM_Y = new System.Windows.Forms.Button();
            this.textBox_MAX_Y = new System.Windows.Forms.TextBox();
            this.textBox_MINY = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.STATUS_COM);
            this.groupBox1.Controls.Add(this.BT_DISC);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.BT_CONNECT);
            this.groupBox1.Controls.Add(this.comboBox_BAUD);
            this.groupBox1.Controls.Add(this.comboBox_COM);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(291, 150);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SET COM";
            // 
            // STATUS_COM
            // 
            this.STATUS_COM.AutoSize = true;
            this.STATUS_COM.Location = new System.Drawing.Point(93, 0);
            this.STATUS_COM.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.STATUS_COM.Name = "STATUS_COM";
            this.STATUS_COM.Size = new System.Drawing.Size(53, 15);
            this.STATUS_COM.TabIndex = 11;
            this.STATUS_COM.Text = "STATUS";
            // 
            // BT_DISC
            // 
            this.BT_DISC.Location = new System.Drawing.Point(13, 103);
            this.BT_DISC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BT_DISC.Name = "BT_DISC";
            this.BT_DISC.Size = new System.Drawing.Size(117, 34);
            this.BT_DISC.TabIndex = 5;
            this.BT_DISC.Text = "DISCONNECT";
            this.BT_DISC.UseVisualStyleBackColor = true;
            this.BT_DISC.Click += new System.EventHandler(this.BT_DISC_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "BAUD :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "COM :";
            // 
            // BT_CONNECT
            // 
            this.BT_CONNECT.Location = new System.Drawing.Point(155, 103);
            this.BT_CONNECT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BT_CONNECT.Name = "BT_CONNECT";
            this.BT_CONNECT.Size = new System.Drawing.Size(117, 34);
            this.BT_CONNECT.TabIndex = 2;
            this.BT_CONNECT.Text = "CONNECT";
            this.BT_CONNECT.UseVisualStyleBackColor = true;
            this.BT_CONNECT.Click += new System.EventHandler(this.BT_CONNECT_Click);
            // 
            // comboBox_BAUD
            // 
            this.comboBox_BAUD.FormattingEnabled = true;
            this.comboBox_BAUD.Location = new System.Drawing.Point(123, 59);
            this.comboBox_BAUD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox_BAUD.Name = "comboBox_BAUD";
            this.comboBox_BAUD.Size = new System.Drawing.Size(148, 23);
            this.comboBox_BAUD.TabIndex = 1;
            // 
            // comboBox_COM
            // 
            this.comboBox_COM.FormattingEnabled = true;
            this.comboBox_COM.Location = new System.Drawing.Point(121, 21);
            this.comboBox_COM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox_COM.Name = "comboBox_COM";
            this.comboBox_COM.Size = new System.Drawing.Size(149, 23);
            this.comboBox_COM.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Controls.Add(this.WARNING_X);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.CONFIRM_X);
            this.groupBox2.Controls.Add(this.textBox_MAX_X);
            this.groupBox2.Controls.Add(this.textBox_MINX);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.Location = new System.Drawing.Point(312, 12);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(291, 150);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Angle X";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label_value_x);
            this.panel2.Location = new System.Drawing.Point(152, 19);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(127, 118);
            this.panel2.TabIndex = 14;
            // 
            // label_value_x
            // 
            this.label_value_x.AutoSize = true;
            this.label_value_x.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_value_x.Location = new System.Drawing.Point(9, 38);
            this.label_value_x.Name = "label_value_x";
            this.label_value_x.Size = new System.Drawing.Size(0, 31);
            this.label_value_x.TabIndex = 1;
            // 
            // WARNING_X
            // 
            this.WARNING_X.AutoSize = true;
            this.WARNING_X.Location = new System.Drawing.Point(91, 0);
            this.WARNING_X.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.WARNING_X.Name = "WARNING_X";
            this.WARNING_X.Size = new System.Drawing.Size(118, 15);
            this.WARNING_X.TabIndex = 13;
            this.WARNING_X.Text = "WARNING ANGLE X";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "MAX :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "MIN :";
            // 
            // CONFIRM_X
            // 
            this.CONFIRM_X.Location = new System.Drawing.Point(13, 106);
            this.CONFIRM_X.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CONFIRM_X.Name = "CONFIRM_X";
            this.CONFIRM_X.Size = new System.Drawing.Size(133, 34);
            this.CONFIRM_X.TabIndex = 8;
            this.CONFIRM_X.Text = "COMFIRM X";
            this.CONFIRM_X.UseVisualStyleBackColor = true;
            this.CONFIRM_X.Click += new System.EventHandler(this.CONFIRM_X_Click);
            // 
            // textBox_MAX_X
            // 
            this.textBox_MAX_X.Location = new System.Drawing.Point(57, 62);
            this.textBox_MAX_X.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_MAX_X.Name = "textBox_MAX_X";
            this.textBox_MAX_X.Size = new System.Drawing.Size(89, 21);
            this.textBox_MAX_X.TabIndex = 2;
            // 
            // textBox_MINX
            // 
            this.textBox_MINX.Location = new System.Drawing.Point(57, 31);
            this.textBox_MINX.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_MINX.Name = "textBox_MINX";
            this.textBox_MINX.Size = new System.Drawing.Size(89, 21);
            this.textBox_MINX.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.panel3);
            this.groupBox3.Controls.Add(this.WARNING_Z);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.CONFIRM_Z);
            this.groupBox3.Controls.Add(this.textBox_MAX_Z);
            this.groupBox3.Controls.Add(this.textBox_MINZ);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox3.Location = new System.Drawing.Point(312, 167);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(291, 150);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Angle Z";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label_value_z);
            this.panel3.Location = new System.Drawing.Point(152, 21);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(127, 118);
            this.panel3.TabIndex = 13;
            // 
            // label_value_z
            // 
            this.label_value_z.AutoSize = true;
            this.label_value_z.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_value_z.Location = new System.Drawing.Point(10, 38);
            this.label_value_z.Name = "label_value_z";
            this.label_value_z.Size = new System.Drawing.Size(0, 31);
            this.label_value_z.TabIndex = 1;
            // 
            // WARNING_Z
            // 
            this.WARNING_Z.AutoSize = true;
            this.WARNING_Z.Location = new System.Drawing.Point(91, 0);
            this.WARNING_Z.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.WARNING_Z.Name = "WARNING_Z";
            this.WARNING_Z.Size = new System.Drawing.Size(117, 15);
            this.WARNING_Z.TabIndex = 12;
            this.WARNING_Z.Text = "WARNING ANGLE Z";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 15);
            this.label7.TabIndex = 11;
            this.label7.Text = "MAX :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 15);
            this.label8.TabIndex = 10;
            this.label8.Text = "MIN :";
            // 
            // CONFIRM_Z
            // 
            this.CONFIRM_Z.Location = new System.Drawing.Point(13, 106);
            this.CONFIRM_Z.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CONFIRM_Z.Name = "CONFIRM_Z";
            this.CONFIRM_Z.Size = new System.Drawing.Size(133, 34);
            this.CONFIRM_Z.TabIndex = 8;
            this.CONFIRM_Z.Text = "CONFIRM Z";
            this.CONFIRM_Z.UseVisualStyleBackColor = true;
            this.CONFIRM_Z.Click += new System.EventHandler(this.CONFIRM_Z_Click);
            // 
            // textBox_MAX_Z
            // 
            this.textBox_MAX_Z.Location = new System.Drawing.Point(57, 60);
            this.textBox_MAX_Z.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_MAX_Z.Name = "textBox_MAX_Z";
            this.textBox_MAX_Z.Size = new System.Drawing.Size(89, 21);
            this.textBox_MAX_Z.TabIndex = 4;
            // 
            // textBox_MINZ
            // 
            this.textBox_MINZ.Location = new System.Drawing.Point(57, 30);
            this.textBox_MINZ.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_MINZ.Name = "textBox_MINZ";
            this.textBox_MINZ.Size = new System.Drawing.Size(89, 21);
            this.textBox_MINZ.TabIndex = 3;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.panel1);
            this.groupBox4.Controls.Add(this.WARNING_Y);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.CONFIRM_Y);
            this.groupBox4.Controls.Add(this.textBox_MAX_Y);
            this.groupBox4.Controls.Add(this.textBox_MINY);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox4.Location = new System.Drawing.Point(12, 167);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Size = new System.Drawing.Size(291, 150);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Angle Y";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label_value_y);
            this.panel1.Location = new System.Drawing.Point(158, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(127, 118);
            this.panel1.TabIndex = 11;
            // 
            // label_value_y
            // 
            this.label_value_y.AutoSize = true;
            this.label_value_y.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_value_y.Location = new System.Drawing.Point(9, 37);
            this.label_value_y.Name = "label_value_y";
            this.label_value_y.Size = new System.Drawing.Size(0, 31);
            this.label_value_y.TabIndex = 0;
            // 
            // WARNING_Y
            // 
            this.WARNING_Y.AutoSize = true;
            this.WARNING_Y.Location = new System.Drawing.Point(93, -2);
            this.WARNING_Y.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.WARNING_Y.Name = "WARNING_Y";
            this.WARNING_Y.Size = new System.Drawing.Size(117, 15);
            this.WARNING_Y.TabIndex = 10;
            this.WARNING_Y.Text = "WARNING ANGLE Y";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "MAX :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "MIN :";
            // 
            // CONFIRM_Y
            // 
            this.CONFIRM_Y.Location = new System.Drawing.Point(19, 106);
            this.CONFIRM_Y.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CONFIRM_Y.Name = "CONFIRM_Y";
            this.CONFIRM_Y.Size = new System.Drawing.Size(133, 34);
            this.CONFIRM_Y.TabIndex = 7;
            this.CONFIRM_Y.Text = "CONFIRM Y";
            this.CONFIRM_Y.UseVisualStyleBackColor = true;
            this.CONFIRM_Y.Click += new System.EventHandler(this.CONFIRM_Y_Click);
            // 
            // textBox_MAX_Y
            // 
            this.textBox_MAX_Y.Location = new System.Drawing.Point(57, 60);
            this.textBox_MAX_Y.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_MAX_Y.Name = "textBox_MAX_Y";
            this.textBox_MAX_Y.Size = new System.Drawing.Size(95, 21);
            this.textBox_MAX_Y.TabIndex = 6;
            // 
            // textBox_MINY
            // 
            this.textBox_MINY.Location = new System.Drawing.Point(57, 30);
            this.textBox_MINY.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_MINY.Name = "textBox_MINY";
            this.textBox_MINY.Size = new System.Drawing.Size(95, 21);
            this.textBox_MINY.TabIndex = 5;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // serialPort
            // 
            this.serialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort_DataReceived);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(620, 331);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MPU6050";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BT_DISC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BT_CONNECT;
        private System.Windows.Forms.ComboBox comboBox_BAUD;
        private System.Windows.Forms.ComboBox comboBox_COM;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button CONFIRM_X;
        private System.Windows.Forms.TextBox textBox_MAX_X;
        private System.Windows.Forms.TextBox textBox_MINX;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button CONFIRM_Z;
        private System.Windows.Forms.TextBox textBox_MAX_Z;
        private System.Windows.Forms.TextBox textBox_MINZ;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button CONFIRM_Y;
        private System.Windows.Forms.TextBox textBox_MAX_Y;
        private System.Windows.Forms.TextBox textBox_MINY;
        private System.Windows.Forms.Label WARNING_Y;
        private System.Windows.Forms.Label STATUS_COM;
        private System.Windows.Forms.Label WARNING_X;
        private System.Windows.Forms.Label WARNING_Z;
        private System.Windows.Forms.Timer timer1;
        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label_value_x;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label_value_z;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_value_y;
    }
}

