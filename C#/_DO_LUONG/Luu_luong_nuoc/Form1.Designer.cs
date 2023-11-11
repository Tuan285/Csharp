namespace Luu_luong_nuoc
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBox_com = new System.Windows.Forms.ComboBox();
            this.comboBox_baud = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_con = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.circularProgressBar_flowrate = new CircularProgressBar.CircularProgressBar();
            this.circularProgressBar_millilit = new CircularProgressBar.CircularProgressBar();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_con);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBox_baud);
            this.groupBox1.Controls.Add(this.comboBox_com);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(308, 87);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "COM";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.circularProgressBar_millilit);
            this.groupBox2.Controls.Add(this.circularProgressBar_flowrate);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(12, 118);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(308, 267);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DATA AND SETTING";
            // 
            // comboBox_com
            // 
            this.comboBox_com.FormattingEnabled = true;
            this.comboBox_com.Location = new System.Drawing.Point(75, 20);
            this.comboBox_com.Name = "comboBox_com";
            this.comboBox_com.Size = new System.Drawing.Size(121, 21);
            this.comboBox_com.TabIndex = 0;
            this.comboBox_com.SelectedIndexChanged += new System.EventHandler(this.comboBox_com_SelectedIndexChanged);
            // 
            // comboBox_baud
            // 
            this.comboBox_baud.FormattingEnabled = true;
            this.comboBox_baud.Location = new System.Drawing.Point(75, 47);
            this.comboBox_baud.Name = "comboBox_baud";
            this.comboBox_baud.Size = new System.Drawing.Size(121, 21);
            this.comboBox_baud.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "COM :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "BAUD :";
            // 
            // button_con
            // 
            this.button_con.Location = new System.Drawing.Point(215, 20);
            this.button_con.Name = "button_con";
            this.button_con.Size = new System.Drawing.Size(76, 48);
            this.button_con.TabIndex = 4;
            this.button_con.Text = "CONNECT";
            this.button_con.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "COM :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(86, 36);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(202, 31);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 25);
            this.button2.TabIndex = 5;
            this.button2.Text = "CONNECT";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // circularProgressBar_flowrate
            // 
            this.circularProgressBar_flowrate.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.circularProgressBar_flowrate.AnimationSpeed = 500;
            this.circularProgressBar_flowrate.BackColor = System.Drawing.Color.Transparent;
            this.circularProgressBar_flowrate.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold);
            this.circularProgressBar_flowrate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.circularProgressBar_flowrate.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.circularProgressBar_flowrate.InnerMargin = 2;
            this.circularProgressBar_flowrate.InnerWidth = -1;
            this.circularProgressBar_flowrate.Location = new System.Drawing.Point(6, 121);
            this.circularProgressBar_flowrate.MarqueeAnimationSpeed = 2000;
            this.circularProgressBar_flowrate.Name = "circularProgressBar_flowrate";
            this.circularProgressBar_flowrate.OuterColor = System.Drawing.Color.Gray;
            this.circularProgressBar_flowrate.OuterMargin = -25;
            this.circularProgressBar_flowrate.OuterWidth = 26;
            this.circularProgressBar_flowrate.ProgressColor = System.Drawing.Color.Yellow;
            this.circularProgressBar_flowrate.ProgressWidth = 25;
            this.circularProgressBar_flowrate.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.circularProgressBar_flowrate.Size = new System.Drawing.Size(140, 140);
            this.circularProgressBar_flowrate.StartAngle = 270;
            this.circularProgressBar_flowrate.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBar_flowrate.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.circularProgressBar_flowrate.SubscriptText = ".23";
            this.circularProgressBar_flowrate.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBar_flowrate.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.circularProgressBar_flowrate.SuperscriptText = "";
            this.circularProgressBar_flowrate.TabIndex = 6;
            this.circularProgressBar_flowrate.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.circularProgressBar_flowrate.Value = 68;
            // 
            // circularProgressBar_millilit
            // 
            this.circularProgressBar_millilit.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.circularProgressBar_millilit.AnimationSpeed = 500;
            this.circularProgressBar_millilit.BackColor = System.Drawing.Color.Transparent;
            this.circularProgressBar_millilit.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold);
            this.circularProgressBar_millilit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.circularProgressBar_millilit.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.circularProgressBar_millilit.InnerMargin = 2;
            this.circularProgressBar_millilit.InnerWidth = -1;
            this.circularProgressBar_millilit.Location = new System.Drawing.Point(157, 121);
            this.circularProgressBar_millilit.MarqueeAnimationSpeed = 2000;
            this.circularProgressBar_millilit.Name = "circularProgressBar_millilit";
            this.circularProgressBar_millilit.OuterColor = System.Drawing.Color.Gray;
            this.circularProgressBar_millilit.OuterMargin = -25;
            this.circularProgressBar_millilit.OuterWidth = 26;
            this.circularProgressBar_millilit.ProgressColor = System.Drawing.Color.Red;
            this.circularProgressBar_millilit.ProgressWidth = 25;
            this.circularProgressBar_millilit.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.circularProgressBar_millilit.Size = new System.Drawing.Size(140, 140);
            this.circularProgressBar_millilit.StartAngle = 270;
            this.circularProgressBar_millilit.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBar_millilit.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.circularProgressBar_millilit.SubscriptText = ".23";
            this.circularProgressBar_millilit.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBar_millilit.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.circularProgressBar_millilit.SuperscriptText = "°C";
            this.circularProgressBar_millilit.TabIndex = 7;
            this.circularProgressBar_millilit.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.circularProgressBar_millilit.Value = 68;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(42, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Flow Rate";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(167, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Total MilliLitres";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 397);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_con;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_baud;
        private System.Windows.Forms.ComboBox comboBox_com;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private CircularProgressBar.CircularProgressBar circularProgressBar_millilit;
        private CircularProgressBar.CircularProgressBar circularProgressBar_flowrate;
    }
}

