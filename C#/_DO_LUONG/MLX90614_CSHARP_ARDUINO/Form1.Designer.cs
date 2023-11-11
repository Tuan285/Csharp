namespace MLX90614_CSHARP_ARDUINO
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
            this.BAUD = new System.Windows.Forms.ComboBox();
            this.COM = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BT_CONNECT_DIS = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BT_OBJ = new System.Windows.Forms.Button();
            this.BT_AMBIENT = new System.Windows.Forms.Button();
            this.BT_COMFIRM = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_max = new System.Windows.Forms.TextBox();
            this.textBox_min = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.stt_ambient1 = new System.Windows.Forms.Label();
            this.stt_ambient = new System.Windows.Forms.Label();
            this.rev_nhietdo_ambient = new CircularProgressBar.CircularProgressBar();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.stt_obj1 = new System.Windows.Forms.Label();
            this.stt_obj = new System.Windows.Forms.Label();
            this.rev_nhietdo_obj = new CircularProgressBar.CircularProgressBar();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BAUD);
            this.groupBox1.Controls.Add(this.COM);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.BT_CONNECT_DIS);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(11, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(150, 161);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kết Nối Và Cài Đặt";
            // 
            // BAUD
            // 
            this.BAUD.FormattingEnabled = true;
            this.BAUD.Location = new System.Drawing.Point(53, 49);
            this.BAUD.Name = "BAUD";
            this.BAUD.Size = new System.Drawing.Size(91, 21);
            this.BAUD.TabIndex = 13;
            this.BAUD.Text = "9600";
            // 
            // COM
            // 
            this.COM.FormattingEnabled = true;
            this.COM.Location = new System.Drawing.Point(53, 17);
            this.COM.Name = "COM";
            this.COM.Size = new System.Drawing.Size(91, 21);
            this.COM.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(12, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Vui Lòng Kết Nối  !!!";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // BT_CONNECT_DIS
            // 
            this.BT_CONNECT_DIS.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.BT_CONNECT_DIS.Location = new System.Drawing.Point(9, 85);
            this.BT_CONNECT_DIS.Name = "BT_CONNECT_DIS";
            this.BT_CONNECT_DIS.Size = new System.Drawing.Size(139, 31);
            this.BT_CONNECT_DIS.TabIndex = 10;
            this.BT_CONNECT_DIS.Text = "Kết Nối";
            this.BT_CONNECT_DIS.UseVisualStyleBackColor = true;
            this.BT_CONNECT_DIS.Click += new System.EventHandler(this.BT_CONNECT_DIS_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "BAUD :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "COM :";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.BT_OBJ);
            this.groupBox3.Controls.Add(this.BT_AMBIENT);
            this.groupBox3.Controls.Add(this.BT_COMFIRM);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.textBox_max);
            this.groupBox3.Controls.Add(this.textBox_min);
            this.groupBox3.Location = new System.Drawing.Point(167, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(150, 161);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Nhiệt Độ Cài Đặt";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // BT_OBJ
            // 
            this.BT_OBJ.Location = new System.Drawing.Point(79, 119);
            this.BT_OBJ.Name = "BT_OBJ";
            this.BT_OBJ.Size = new System.Drawing.Size(63, 36);
            this.BT_OBJ.TabIndex = 14;
            this.BT_OBJ.Text = "OBJECT";
            this.BT_OBJ.UseVisualStyleBackColor = true;
            this.BT_OBJ.Click += new System.EventHandler(this.button1_Click);
            // 
            // BT_AMBIENT
            // 
            this.BT_AMBIENT.Location = new System.Drawing.Point(6, 119);
            this.BT_AMBIENT.Name = "BT_AMBIENT";
            this.BT_AMBIENT.Size = new System.Drawing.Size(63, 36);
            this.BT_AMBIENT.TabIndex = 13;
            this.BT_AMBIENT.Text = "AMBIENT";
            this.BT_AMBIENT.UseVisualStyleBackColor = true;
            this.BT_AMBIENT.Click += new System.EventHandler(this.BT_AMBIENT_Click);
            // 
            // BT_COMFIRM
            // 
            this.BT_COMFIRM.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.BT_COMFIRM.Location = new System.Drawing.Point(6, 83);
            this.BT_COMFIRM.Name = "BT_COMFIRM";
            this.BT_COMFIRM.Size = new System.Drawing.Size(138, 30);
            this.BT_COMFIRM.TabIndex = 12;
            this.BT_COMFIRM.Text = "Xác Nhận";
            this.BT_COMFIRM.UseVisualStyleBackColor = true;
            this.BT_COMFIRM.Click += new System.EventHandler(this.BT_COMFIRM_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "MAX :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "MIN :";
            // 
            // textBox_max
            // 
            this.textBox_max.Location = new System.Drawing.Point(44, 49);
            this.textBox_max.Name = "textBox_max";
            this.textBox_max.Size = new System.Drawing.Size(100, 20);
            this.textBox_max.TabIndex = 1;
            // 
            // textBox_min
            // 
            this.textBox_min.Location = new System.Drawing.Point(44, 19);
            this.textBox_min.Name = "textBox_min";
            this.textBox_min.Size = new System.Drawing.Size(100, 20);
            this.textBox_min.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.stt_ambient1);
            this.groupBox4.Controls.Add(this.stt_ambient);
            this.groupBox4.Controls.Add(this.rev_nhietdo_ambient);
            this.groupBox4.Location = new System.Drawing.Point(11, 176);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(150, 160);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Nhiệt Độ Đo Môi Trường";
            // 
            // stt_ambient1
            // 
            this.stt_ambient1.AutoSize = true;
            this.stt_ambient1.Location = new System.Drawing.Point(6, 140);
            this.stt_ambient1.Name = "stt_ambient1";
            this.stt_ambient1.Size = new System.Drawing.Size(0, 13);
            this.stt_ambient1.TabIndex = 2;
            // 
            // stt_ambient
            // 
            this.stt_ambient.AutoSize = true;
            this.stt_ambient.Location = new System.Drawing.Point(7, 141);
            this.stt_ambient.Name = "stt_ambient";
            this.stt_ambient.Size = new System.Drawing.Size(0, 13);
            this.stt_ambient.TabIndex = 1;
            // 
            // rev_nhietdo_ambient
            // 
            this.rev_nhietdo_ambient.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.rev_nhietdo_ambient.AnimationSpeed = 500;
            this.rev_nhietdo_ambient.BackColor = System.Drawing.Color.Transparent;
            this.rev_nhietdo_ambient.Enabled = false;
            this.rev_nhietdo_ambient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.rev_nhietdo_ambient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rev_nhietdo_ambient.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.rev_nhietdo_ambient.InnerMargin = 2;
            this.rev_nhietdo_ambient.InnerWidth = -1;
            this.rev_nhietdo_ambient.Location = new System.Drawing.Point(9, 22);
            this.rev_nhietdo_ambient.MarqueeAnimationSpeed = 2000;
            this.rev_nhietdo_ambient.Name = "rev_nhietdo_ambient";
            this.rev_nhietdo_ambient.OuterColor = System.Drawing.Color.Gray;
            this.rev_nhietdo_ambient.OuterMargin = -25;
            this.rev_nhietdo_ambient.OuterWidth = 26;
            this.rev_nhietdo_ambient.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.rev_nhietdo_ambient.ProgressWidth = 12;
            this.rev_nhietdo_ambient.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.rev_nhietdo_ambient.Size = new System.Drawing.Size(100, 100);
            this.rev_nhietdo_ambient.StartAngle = 270;
            this.rev_nhietdo_ambient.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.rev_nhietdo_ambient.SubscriptMargin = new System.Windows.Forms.Padding(0);
            this.rev_nhietdo_ambient.SubscriptText = "";
            this.rev_nhietdo_ambient.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.rev_nhietdo_ambient.SuperscriptMargin = new System.Windows.Forms.Padding(0);
            this.rev_nhietdo_ambient.SuperscriptText = "";
            this.rev_nhietdo_ambient.TabIndex = 0;
            this.rev_nhietdo_ambient.Text = "12";
            this.rev_nhietdo_ambient.TextMargin = new System.Windows.Forms.Padding(0);
            this.rev_nhietdo_ambient.Value = 10;
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 500;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.stt_obj1);
            this.groupBox5.Controls.Add(this.stt_obj);
            this.groupBox5.Controls.Add(this.rev_nhietdo_obj);
            this.groupBox5.Location = new System.Drawing.Point(167, 179);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(150, 157);
            this.groupBox5.TabIndex = 8;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Nhiệt Độ Đo Vật Thể";
            // 
            // stt_obj1
            // 
            this.stt_obj1.AutoSize = true;
            this.stt_obj1.Location = new System.Drawing.Point(7, 137);
            this.stt_obj1.Name = "stt_obj1";
            this.stt_obj1.Size = new System.Drawing.Size(0, 13);
            this.stt_obj1.TabIndex = 2;
            // 
            // stt_obj
            // 
            this.stt_obj.AutoSize = true;
            this.stt_obj.Location = new System.Drawing.Point(7, 137);
            this.stt_obj.Name = "stt_obj";
            this.stt_obj.Size = new System.Drawing.Size(0, 13);
            this.stt_obj.TabIndex = 1;
            // 
            // rev_nhietdo_obj
            // 
            this.rev_nhietdo_obj.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.rev_nhietdo_obj.AnimationSpeed = 500;
            this.rev_nhietdo_obj.BackColor = System.Drawing.Color.Transparent;
            this.rev_nhietdo_obj.Enabled = false;
            this.rev_nhietdo_obj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.rev_nhietdo_obj.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rev_nhietdo_obj.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.rev_nhietdo_obj.InnerMargin = 2;
            this.rev_nhietdo_obj.InnerWidth = -1;
            this.rev_nhietdo_obj.Location = new System.Drawing.Point(20, 19);
            this.rev_nhietdo_obj.MarqueeAnimationSpeed = 2000;
            this.rev_nhietdo_obj.Name = "rev_nhietdo_obj";
            this.rev_nhietdo_obj.OuterColor = System.Drawing.Color.Gray;
            this.rev_nhietdo_obj.OuterMargin = -25;
            this.rev_nhietdo_obj.OuterWidth = 26;
            this.rev_nhietdo_obj.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.rev_nhietdo_obj.ProgressWidth = 12;
            this.rev_nhietdo_obj.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.rev_nhietdo_obj.Size = new System.Drawing.Size(100, 100);
            this.rev_nhietdo_obj.StartAngle = 270;
            this.rev_nhietdo_obj.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.rev_nhietdo_obj.SubscriptMargin = new System.Windows.Forms.Padding(0);
            this.rev_nhietdo_obj.SubscriptText = "";
            this.rev_nhietdo_obj.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.rev_nhietdo_obj.SuperscriptMargin = new System.Windows.Forms.Padding(0);
            this.rev_nhietdo_obj.SuperscriptText = "";
            this.rev_nhietdo_obj.TabIndex = 0;
            this.rev_nhietdo_obj.Text = "12";
            this.rev_nhietdo_obj.TextMargin = new System.Windows.Forms.Padding(0);
            this.rev_nhietdo_obj.Value = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(7, 349);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Thời Gian :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(91, 350);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 20);
            this.label4.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 378);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "ARDUINO MLX90614";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BT_CONNECT_DIS;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.ComboBox BAUD;
        private System.Windows.Forms.ComboBox COM;
        private CircularProgressBar.CircularProgressBar rev_nhietdo_ambient;
        private System.Windows.Forms.TextBox textBox_max;
        private System.Windows.Forms.TextBox textBox_min;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BT_COMFIRM;
        private System.Windows.Forms.GroupBox groupBox5;
        private CircularProgressBar.CircularProgressBar rev_nhietdo_obj;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BT_OBJ;
        private System.Windows.Forms.Button BT_AMBIENT;
        private System.Windows.Forms.Label stt_ambient;
        private System.Windows.Forms.Label stt_obj;
        private System.Windows.Forms.Label stt_ambient1;
        private System.Windows.Forms.Label stt_obj1;
    }
}

