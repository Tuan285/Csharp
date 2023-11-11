namespace RS485_ARDUINOV1
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
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxCom = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxBaud = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.circularProgressBarSlave1 = new CircularProgressBar.CircularProgressBar();
            this.pictureBoxSlave1 = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.circularProgressBarSlave2 = new CircularProgressBar.CircularProgressBar();
            this.pictureBoxSlave2 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.circularProgressBarSlave3 = new CircularProgressBar.CircularProgressBar();
            this.pictureBoxSlave3 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSlave1)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSlave2)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSlave3)).BeginInit();
            this.SuspendLayout();
            // 
            // serialPort
            // 
            this.serialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort_DataReceived);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBoxCom);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.buttonConnect);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboBoxBaud);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(549, 84);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "COM";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "COM :";
            // 
            // comboBoxCom
            // 
            this.comboBoxCom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCom.FormattingEnabled = true;
            this.comboBoxCom.Location = new System.Drawing.Point(108, 8);
            this.comboBoxCom.Name = "comboBoxCom";
            this.comboBoxCom.Size = new System.Drawing.Size(164, 28);
            this.comboBoxCom.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(311, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "label6";
            // 
            // buttonConnect
            // 
            this.buttonConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConnect.Location = new System.Drawing.Point(314, 37);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(171, 37);
            this.buttonConnect.TabIndex = 4;
            this.buttonConnect.Text = "CONNECT";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "BAUD :";
            // 
            // comboBoxBaud
            // 
            this.comboBoxBaud.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxBaud.FormattingEnabled = true;
            this.comboBoxBaud.Location = new System.Drawing.Point(108, 42);
            this.comboBoxBaud.Name = "comboBoxBaud";
            this.comboBoxBaud.Size = new System.Drawing.Size(164, 28);
            this.comboBoxBaud.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.circularProgressBarSlave1);
            this.groupBox2.Controls.Add(this.pictureBoxSlave1);
            this.groupBox2.Location = new System.Drawing.Point(12, 102);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(180, 350);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "SLAVE 1";
            // 
            // circularProgressBarSlave1
            // 
            this.circularProgressBarSlave1.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.circularProgressBarSlave1.AnimationSpeed = 500;
            this.circularProgressBarSlave1.BackColor = System.Drawing.Color.Transparent;
            this.circularProgressBarSlave1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.circularProgressBarSlave1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.circularProgressBarSlave1.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.circularProgressBarSlave1.InnerMargin = 2;
            this.circularProgressBarSlave1.InnerWidth = -1;
            this.circularProgressBarSlave1.Location = new System.Drawing.Point(10, 183);
            this.circularProgressBarSlave1.MarqueeAnimationSpeed = 2000;
            this.circularProgressBarSlave1.Name = "circularProgressBarSlave1";
            this.circularProgressBarSlave1.OuterColor = System.Drawing.Color.Gray;
            this.circularProgressBarSlave1.OuterMargin = -25;
            this.circularProgressBarSlave1.OuterWidth = 26;
            this.circularProgressBarSlave1.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.circularProgressBarSlave1.ProgressWidth = 25;
            this.circularProgressBarSlave1.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.circularProgressBarSlave1.Size = new System.Drawing.Size(150, 150);
            this.circularProgressBarSlave1.StartAngle = 270;
            this.circularProgressBarSlave1.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBarSlave1.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.circularProgressBarSlave1.SubscriptText = "";
            this.circularProgressBarSlave1.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBarSlave1.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.circularProgressBarSlave1.SuperscriptText = "";
            this.circularProgressBarSlave1.TabIndex = 2;
            this.circularProgressBarSlave1.Text = "DATA";
            this.circularProgressBarSlave1.TextMargin = new System.Windows.Forms.Padding(0);
            this.circularProgressBarSlave1.Value = 68;
            // 
            // pictureBoxSlave1
            // 
            this.pictureBoxSlave1.Image = global::RS485_ARDUINOV1.Properties.Resources.light_off;
            this.pictureBoxSlave1.Location = new System.Drawing.Point(37, 19);
            this.pictureBoxSlave1.Name = "pictureBoxSlave1";
            this.pictureBoxSlave1.Size = new System.Drawing.Size(110, 110);
            this.pictureBoxSlave1.TabIndex = 0;
            this.pictureBoxSlave1.TabStop = false;
            this.pictureBoxSlave1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.circularProgressBarSlave2);
            this.groupBox3.Controls.Add(this.pictureBoxSlave2);
            this.groupBox3.Location = new System.Drawing.Point(198, 102);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(180, 350);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "SLAVE 2";
            // 
            // circularProgressBarSlave2
            // 
            this.circularProgressBarSlave2.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.circularProgressBarSlave2.AnimationSpeed = 500;
            this.circularProgressBarSlave2.BackColor = System.Drawing.Color.Transparent;
            this.circularProgressBarSlave2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.circularProgressBarSlave2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.circularProgressBarSlave2.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.circularProgressBarSlave2.InnerMargin = 2;
            this.circularProgressBarSlave2.InnerWidth = -1;
            this.circularProgressBarSlave2.Location = new System.Drawing.Point(16, 183);
            this.circularProgressBarSlave2.MarqueeAnimationSpeed = 2000;
            this.circularProgressBarSlave2.Name = "circularProgressBarSlave2";
            this.circularProgressBarSlave2.OuterColor = System.Drawing.Color.Gray;
            this.circularProgressBarSlave2.OuterMargin = -25;
            this.circularProgressBarSlave2.OuterWidth = 26;
            this.circularProgressBarSlave2.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.circularProgressBarSlave2.ProgressWidth = 25;
            this.circularProgressBarSlave2.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.circularProgressBarSlave2.Size = new System.Drawing.Size(150, 150);
            this.circularProgressBarSlave2.StartAngle = 270;
            this.circularProgressBarSlave2.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBarSlave2.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.circularProgressBarSlave2.SubscriptText = "";
            this.circularProgressBarSlave2.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBarSlave2.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.circularProgressBarSlave2.SuperscriptText = "";
            this.circularProgressBarSlave2.TabIndex = 7;
            this.circularProgressBarSlave2.Text = "DATA";
            this.circularProgressBarSlave2.TextMargin = new System.Windows.Forms.Padding(0);
            this.circularProgressBarSlave2.Value = 68;
            // 
            // pictureBoxSlave2
            // 
            this.pictureBoxSlave2.Image = global::RS485_ARDUINOV1.Properties.Resources.light_off;
            this.pictureBoxSlave2.Location = new System.Drawing.Point(37, 19);
            this.pictureBoxSlave2.Name = "pictureBoxSlave2";
            this.pictureBoxSlave2.Size = new System.Drawing.Size(110, 110);
            this.pictureBoxSlave2.TabIndex = 6;
            this.pictureBoxSlave2.TabStop = false;
            this.pictureBoxSlave2.Click += new System.EventHandler(this.pictureBoxSlave2_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.circularProgressBarSlave3);
            this.groupBox4.Controls.Add(this.pictureBoxSlave3);
            this.groupBox4.Location = new System.Drawing.Point(384, 102);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(180, 350);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "SLAVE 3";
            // 
            // circularProgressBarSlave3
            // 
            this.circularProgressBarSlave3.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.circularProgressBarSlave3.AnimationSpeed = 500;
            this.circularProgressBarSlave3.BackColor = System.Drawing.Color.Transparent;
            this.circularProgressBarSlave3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.circularProgressBarSlave3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.circularProgressBarSlave3.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.circularProgressBarSlave3.InnerMargin = 2;
            this.circularProgressBarSlave3.InnerWidth = -1;
            this.circularProgressBarSlave3.Location = new System.Drawing.Point(16, 183);
            this.circularProgressBarSlave3.MarqueeAnimationSpeed = 2000;
            this.circularProgressBarSlave3.Name = "circularProgressBarSlave3";
            this.circularProgressBarSlave3.OuterColor = System.Drawing.Color.Gray;
            this.circularProgressBarSlave3.OuterMargin = -25;
            this.circularProgressBarSlave3.OuterWidth = 26;
            this.circularProgressBarSlave3.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.circularProgressBarSlave3.ProgressWidth = 25;
            this.circularProgressBarSlave3.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.circularProgressBarSlave3.Size = new System.Drawing.Size(150, 150);
            this.circularProgressBarSlave3.StartAngle = 270;
            this.circularProgressBarSlave3.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBarSlave3.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.circularProgressBarSlave3.SubscriptText = "";
            this.circularProgressBarSlave3.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBarSlave3.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.circularProgressBarSlave3.SuperscriptText = "";
            this.circularProgressBarSlave3.TabIndex = 7;
            this.circularProgressBarSlave3.Text = "DATA";
            this.circularProgressBarSlave3.TextMargin = new System.Windows.Forms.Padding(0);
            this.circularProgressBarSlave3.Value = 68;
            // 
            // pictureBoxSlave3
            // 
            this.pictureBoxSlave3.Image = global::RS485_ARDUINOV1.Properties.Resources.light_off;
            this.pictureBoxSlave3.Location = new System.Drawing.Point(33, 19);
            this.pictureBoxSlave3.Name = "pictureBoxSlave3";
            this.pictureBoxSlave3.Size = new System.Drawing.Size(110, 110);
            this.pictureBoxSlave3.TabIndex = 6;
            this.pictureBoxSlave3.TabStop = false;
            this.pictureBoxSlave3.Click += new System.EventHandler(this.pictureBoxSlave3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(573, 458);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "RS485";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSlave1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSlave2)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSlave3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxBaud;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox pictureBoxSlave1;
        private System.Windows.Forms.PictureBox pictureBoxSlave2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label6;
        private CircularProgressBar.CircularProgressBar circularProgressBarSlave1;
        private CircularProgressBar.CircularProgressBar circularProgressBarSlave2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxCom;
        private System.Windows.Forms.GroupBox groupBox4;
        private CircularProgressBar.CircularProgressBar circularProgressBarSlave3;
        private System.Windows.Forms.PictureBox pictureBoxSlave3;
    }
}

