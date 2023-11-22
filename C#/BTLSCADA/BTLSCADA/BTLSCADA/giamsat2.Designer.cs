namespace BTLSCADA
{
    partial class giamsat2
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
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.butloc_on = new System.Windows.Forms.Button();
            this.butloc_up = new System.Windows.Forms.Button();
            this.butloc_off = new System.Windows.Forms.Button();
            this.cboloc = new System.Windows.Forms.ComboBox();
            this.butloc_auto = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.butoxi_on = new System.Windows.Forms.Button();
            this.butoxi_up = new System.Windows.Forms.Button();
            this.butoxi_off = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.butoxi_auto = new System.Windows.Forms.Button();
            this.cbooxi = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtledoff_up = new System.Windows.Forms.TextBox();
            this.txtledon_up = new System.Windows.Forms.TextBox();
            this.butLed_up = new System.Windows.Forms.Button();
            this.butLed_on = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.butLed_off = new System.Windows.Forms.Button();
            this.butLed_auto = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.serCOM = new System.IO.Ports.SerialPort(this.components);
            this.butpage1 = new System.Windows.Forms.Button();
            this.butpage3 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.butloc_on);
            this.groupBox5.Controls.Add(this.butloc_up);
            this.groupBox5.Controls.Add(this.butloc_off);
            this.groupBox5.Controls.Add(this.cboloc);
            this.groupBox5.Controls.Add(this.butloc_auto);
            this.groupBox5.Controls.Add(this.label16);
            this.groupBox5.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(12, 626);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(646, 253);
            this.groupBox5.TabIndex = 118;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Máy Lọc Nước";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(45, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 27);
            this.label2.TabIndex = 84;
            this.label2.Text = "Chế độ AUTO";
            // 
            // butloc_on
            // 
            this.butloc_on.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butloc_on.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.butloc_on.Location = new System.Drawing.Point(44, 53);
            this.butloc_on.Name = "butloc_on";
            this.butloc_on.Size = new System.Drawing.Size(145, 39);
            this.butloc_on.TabIndex = 87;
            this.butloc_on.Text = "ON";
            this.butloc_on.UseVisualStyleBackColor = true;
            this.butloc_on.Click += new System.EventHandler(this.butloc_on_Click);
            // 
            // butloc_up
            // 
            this.butloc_up.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butloc_up.Location = new System.Drawing.Point(141, 192);
            this.butloc_up.Name = "butloc_up";
            this.butloc_up.Size = new System.Drawing.Size(112, 45);
            this.butloc_up.TabIndex = 84;
            this.butloc_up.Text = "Cập nhật";
            this.butloc_up.UseVisualStyleBackColor = true;
            this.butloc_up.Click += new System.EventHandler(this.butloc_up_Click);
            // 
            // butloc_off
            // 
            this.butloc_off.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butloc_off.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.butloc_off.Location = new System.Drawing.Point(256, 53);
            this.butloc_off.Name = "butloc_off";
            this.butloc_off.Size = new System.Drawing.Size(158, 39);
            this.butloc_off.TabIndex = 88;
            this.butloc_off.Text = "OFF";
            this.butloc_off.UseVisualStyleBackColor = true;
            this.butloc_off.Click += new System.EventHandler(this.butloc_off_Click);
            // 
            // cboloc
            // 
            this.cboloc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboloc.FormattingEnabled = true;
            this.cboloc.Location = new System.Drawing.Point(226, 111);
            this.cboloc.Name = "cboloc";
            this.cboloc.Size = new System.Drawing.Size(406, 30);
            this.cboloc.TabIndex = 81;
            this.cboloc.SelectedIndexChanged += new System.EventHandler(this.cboloc_SelectedIndexChanged);
            // 
            // butloc_auto
            // 
            this.butloc_auto.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butloc_auto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.butloc_auto.Location = new System.Drawing.Point(464, 53);
            this.butloc_auto.Name = "butloc_auto";
            this.butloc_auto.Size = new System.Drawing.Size(159, 39);
            this.butloc_auto.TabIndex = 89;
            this.butloc_auto.Text = "AUTO";
            this.butloc_auto.UseVisualStyleBackColor = true;
            this.butloc_auto.Click += new System.EventHandler(this.butloc_auto_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(35, 155);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(330, 22);
            this.label16.TabIndex = 64;
            this.label16.Text = "Số lần lọc trong ngày (mỗi lần lọc 1 giờ)";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.butoxi_on);
            this.groupBox4.Controls.Add(this.butoxi_up);
            this.groupBox4.Controls.Add(this.butoxi_off);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.butoxi_auto);
            this.groupBox4.Controls.Add(this.cbooxi);
            this.groupBox4.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(12, 362);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(646, 258);
            this.groupBox4.TabIndex = 117;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Bơm Oxi";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(39, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 27);
            this.label3.TabIndex = 85;
            this.label3.Text = "Chế độ AUTO";
            // 
            // butoxi_on
            // 
            this.butoxi_on.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butoxi_on.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.butoxi_on.Location = new System.Drawing.Point(44, 56);
            this.butoxi_on.Name = "butoxi_on";
            this.butoxi_on.Size = new System.Drawing.Size(145, 39);
            this.butoxi_on.TabIndex = 84;
            this.butoxi_on.Text = "ON";
            this.butoxi_on.UseVisualStyleBackColor = true;
            this.butoxi_on.Click += new System.EventHandler(this.butoxi_on_Click);
            // 
            // butoxi_up
            // 
            this.butoxi_up.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butoxi_up.Location = new System.Drawing.Point(141, 193);
            this.butoxi_up.Name = "butoxi_up";
            this.butoxi_up.Size = new System.Drawing.Size(112, 45);
            this.butoxi_up.TabIndex = 85;
            this.butoxi_up.Text = "Cập nhật";
            this.butoxi_up.UseVisualStyleBackColor = true;
            this.butoxi_up.Click += new System.EventHandler(this.butoxi_up_Click);
            // 
            // butoxi_off
            // 
            this.butoxi_off.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butoxi_off.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.butoxi_off.Location = new System.Drawing.Point(256, 56);
            this.butoxi_off.Name = "butoxi_off";
            this.butoxi_off.Size = new System.Drawing.Size(158, 39);
            this.butoxi_off.TabIndex = 85;
            this.butoxi_off.Text = "OFF";
            this.butoxi_off.UseVisualStyleBackColor = true;
            this.butoxi_off.Click += new System.EventHandler(this.butoxi_off_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(40, 156);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(350, 22);
            this.label15.TabIndex = 63;
            this.label15.Text = "Số lần bơm trong ngày (mỗi lần bơm 2 giờ)";
            // 
            // butoxi_auto
            // 
            this.butoxi_auto.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butoxi_auto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.butoxi_auto.Location = new System.Drawing.Point(464, 56);
            this.butoxi_auto.Name = "butoxi_auto";
            this.butoxi_auto.Size = new System.Drawing.Size(168, 39);
            this.butoxi_auto.TabIndex = 86;
            this.butoxi_auto.Text = "AUTO";
            this.butoxi_auto.UseVisualStyleBackColor = true;
            this.butoxi_auto.Click += new System.EventHandler(this.butoxi_auto_Click);
            // 
            // cbooxi
            // 
            this.cbooxi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbooxi.FormattingEnabled = true;
            this.cbooxi.Location = new System.Drawing.Point(218, 111);
            this.cbooxi.Name = "cbooxi";
            this.cbooxi.Size = new System.Drawing.Size(414, 30);
            this.cbooxi.TabIndex = 76;
            this.cbooxi.SelectedIndexChanged += new System.EventHandler(this.cbooxi_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtledoff_up);
            this.groupBox2.Controls.Add(this.txtledon_up);
            this.groupBox2.Controls.Add(this.butLed_up);
            this.groupBox2.Controls.Add(this.butLed_on);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.butLed_off);
            this.groupBox2.Controls.Add(this.butLed_auto);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(18, 66);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(640, 290);
            this.groupBox2.TabIndex = 120;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Đèn Led";
            // 
            // txtledoff_up
            // 
            this.txtledoff_up.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtledoff_up.Location = new System.Drawing.Point(265, 159);
            this.txtledoff_up.Name = "txtledoff_up";
            this.txtledoff_up.Size = new System.Drawing.Size(361, 30);
            this.txtledoff_up.TabIndex = 85;
            this.txtledoff_up.Text = "7";
            this.txtledoff_up.TextChanged += new System.EventHandler(this.txtledoff_up_TextChanged);
            // 
            // txtledon_up
            // 
            this.txtledon_up.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtledon_up.Location = new System.Drawing.Point(265, 123);
            this.txtledon_up.Name = "txtledon_up";
            this.txtledon_up.Size = new System.Drawing.Size(361, 30);
            this.txtledon_up.TabIndex = 84;
            this.txtledon_up.Text = "6";
            this.txtledon_up.TextChanged += new System.EventHandler(this.txtledon_up_TextChanged);
            // 
            // butLed_up
            // 
            this.butLed_up.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butLed_up.Location = new System.Drawing.Point(135, 229);
            this.butLed_up.Name = "butLed_up";
            this.butLed_up.Size = new System.Drawing.Size(112, 45);
            this.butLed_up.TabIndex = 83;
            this.butLed_up.Text = "Cập nhật";
            this.butLed_up.UseVisualStyleBackColor = true;
            this.butLed_up.Click += new System.EventHandler(this.butLed_up_Click);
            // 
            // butLed_on
            // 
            this.butLed_on.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butLed_on.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.butLed_on.Location = new System.Drawing.Point(40, 56);
            this.butLed_on.Name = "butLed_on";
            this.butLed_on.Size = new System.Drawing.Size(143, 39);
            this.butLed_on.TabIndex = 41;
            this.butLed_on.Text = "ON";
            this.butLed_on.UseVisualStyleBackColor = true;
            this.butLed_on.Click += new System.EventHandler(this.butLed_on_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(36, 192);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(249, 22);
            this.label18.TabIndex = 82;
            this.label18.Text = "Tùy chọn thời gian bật đèn led";
            // 
            // butLed_off
            // 
            this.butLed_off.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butLed_off.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.butLed_off.Location = new System.Drawing.Point(250, 56);
            this.butLed_off.Name = "butLed_off";
            this.butLed_off.Size = new System.Drawing.Size(158, 39);
            this.butLed_off.TabIndex = 42;
            this.butLed_off.Text = "OFF";
            this.butLed_off.UseVisualStyleBackColor = true;
            this.butLed_off.Click += new System.EventHandler(this.butLed_off_Click);
            // 
            // butLed_auto
            // 
            this.butLed_auto.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butLed_auto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.butLed_auto.Location = new System.Drawing.Point(458, 56);
            this.butLed_auto.Name = "butLed_auto";
            this.butLed_auto.Size = new System.Drawing.Size(168, 39);
            this.butLed_auto.TabIndex = 43;
            this.butLed_auto.Text = "AUTO";
            this.butLed_auto.UseVisualStyleBackColor = true;
            this.butLed_auto.Click += new System.EventHandler(this.butLed_auto_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label19.Location = new System.Drawing.Point(35, 126);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(150, 27);
            this.label19.TabIndex = 71;
            this.label19.Text = "Chế độ AUTO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(429, 38);
            this.label1.TabIndex = 119;
            this.label1.Text = "Hệ Thống Nuôi Cá Tự Động";
            // 
            // serCOM
            // 
            this.serCOM.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serCOM_DataReceived);
            // 
            // butpage1
            // 
            this.butpage1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butpage1.Location = new System.Drawing.Point(468, 12);
            this.butpage1.Name = "butpage1";
            this.butpage1.Size = new System.Drawing.Size(89, 48);
            this.butpage1.TabIndex = 129;
            this.butpage1.Text = "page 1";
            this.butpage1.UseVisualStyleBackColor = true;
            this.butpage1.Click += new System.EventHandler(this.butpage1_Click);
            // 
            // butpage3
            // 
            this.butpage3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butpage3.Location = new System.Drawing.Point(574, 12);
            this.butpage3.Name = "butpage3";
            this.butpage3.Size = new System.Drawing.Size(84, 48);
            this.butpage3.TabIndex = 128;
            this.butpage3.Text = "page 3";
            this.butpage3.UseVisualStyleBackColor = true;
            this.butpage3.Click += new System.EventHandler(this.butpage3_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // giamsat2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 890);
            this.Controls.Add(this.butpage1);
            this.Controls.Add(this.butpage3);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Name = "giamsat2";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.giamsat2_Load);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button butloc_on;
        private System.Windows.Forms.Button butloc_up;
        private System.Windows.Forms.Button butloc_off;
        private System.Windows.Forms.ComboBox cboloc;
        private System.Windows.Forms.Button butloc_auto;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button butoxi_on;
        private System.Windows.Forms.Button butoxi_up;
        private System.Windows.Forms.Button butoxi_off;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button butoxi_auto;
        private System.Windows.Forms.ComboBox cbooxi;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button butLed_up;
        private System.Windows.Forms.Button butLed_on;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button butLed_off;
        private System.Windows.Forms.Button butLed_auto;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label1;
        private System.IO.Ports.SerialPort serCOM;
        private System.Windows.Forms.Button butpage1;
        private System.Windows.Forms.Button butpage3;
        private System.Windows.Forms.TextBox txtledoff_up;
        private System.Windows.Forms.TextBox txtledon_up;
        private System.Windows.Forms.Timer timer1;
    }
}