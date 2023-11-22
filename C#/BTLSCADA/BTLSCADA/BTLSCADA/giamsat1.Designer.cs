namespace BTLSCADA
{
    partial class giamsat1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtTemp = new System.Windows.Forms.Label();
            this.lbtrangthai = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.butnhietdo_up = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtnhietdothap_up = new System.Windows.Forms.TextBox();
            this.txtnhietdocao_up = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cboluongthucan = new System.Windows.Forms.ComboBox();
            this.txtthucan_hienthi = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtgiochoan_up = new System.Windows.Forms.TextBox();
            this.butthucan_up = new System.Windows.Forms.Button();
            this.serCOM = new System.IO.Ports.SerialPort(this.components);
            this.butpage3 = new System.Windows.Forms.Button();
            this.butpage2 = new System.Windows.Forms.Button();
            this.butExit = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.txtTemp);
            this.groupBox4.Controls.Add(this.lbtrangthai);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label18);
            this.groupBox4.Controls.Add(this.butnhietdo_up);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.txtnhietdothap_up);
            this.groupBox4.Controls.Add(this.txtnhietdocao_up);
            this.groupBox4.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(23, 378);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(402, 351);
            this.groupBox4.TabIndex = 123;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Nhiệt Độ";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Red;
            this.label15.Location = new System.Drawing.Point(214, 155);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(76, 26);
            this.label15.TabIndex = 121;
            this.label15.Text = "None !";
            // 
            // txtTemp
            // 
            this.txtTemp.AutoSize = true;
            this.txtTemp.ForeColor = System.Drawing.Color.Red;
            this.txtTemp.Location = new System.Drawing.Point(212, 47);
            this.txtTemp.Name = "txtTemp";
            this.txtTemp.Size = new System.Drawing.Size(114, 37);
            this.txtTemp.TabIndex = 120;
            this.txtTemp.Text = "label15";
            // 
            // lbtrangthai
            // 
            this.lbtrangthai.AutoSize = true;
            this.lbtrangthai.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtrangthai.ForeColor = System.Drawing.Color.Red;
            this.lbtrangthai.Location = new System.Drawing.Point(214, 99);
            this.lbtrangthai.Name = "lbtrangthai";
            this.lbtrangthai.Size = new System.Drawing.Size(76, 26);
            this.lbtrangthai.TabIndex = 117;
            this.lbtrangthai.Text = "None !";
            this.lbtrangthai.Click += new System.EventHandler(this.lbtrangthai_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(19, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(183, 26);
            this.label6.TabIndex = 115;
            this.label6.Text = "Cảnh báo nhiệt độ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 255);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 26);
            this.label5.TabIndex = 102;
            this.label5.Text = "Từ";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(19, 56);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(166, 26);
            this.label18.TabIndex = 82;
            this.label18.Text = "Nhiệt độ hiện tại";
            // 
            // butnhietdo_up
            // 
            this.butnhietdo_up.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butnhietdo_up.Location = new System.Drawing.Point(127, 298);
            this.butnhietdo_up.Name = "butnhietdo_up";
            this.butnhietdo_up.Size = new System.Drawing.Size(112, 45);
            this.butnhietdo_up.TabIndex = 83;
            this.butnhietdo_up.Text = "Cập nhật";
            this.butnhietdo_up.UseVisualStyleBackColor = true;
            this.butnhietdo_up.Click += new System.EventHandler(this.butnhietdo_up_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(179, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 26);
            this.label3.TabIndex = 101;
            this.label3.Text = "đến";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 26);
            this.label2.TabIndex = 85;
            this.label2.Text = "Trạng thái";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 26);
            this.label4.TabIndex = 97;
            this.label4.Text = "Cài đặt nhiệt độ";
            // 
            // txtnhietdothap_up
            // 
            this.txtnhietdothap_up.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnhietdothap_up.Location = new System.Drawing.Point(65, 251);
            this.txtnhietdothap_up.Name = "txtnhietdothap_up";
            this.txtnhietdothap_up.Size = new System.Drawing.Size(108, 30);
            this.txtnhietdothap_up.TabIndex = 100;
            this.txtnhietdothap_up.Text = "20";
            this.txtnhietdothap_up.TextChanged += new System.EventHandler(this.txtnhietdothap_up_TextChanged);
            // 
            // txtnhietdocao_up
            // 
            this.txtnhietdocao_up.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnhietdocao_up.Location = new System.Drawing.Point(231, 251);
            this.txtnhietdocao_up.Name = "txtnhietdocao_up";
            this.txtnhietdocao_up.Size = new System.Drawing.Size(108, 30);
            this.txtnhietdocao_up.TabIndex = 98;
            this.txtnhietdocao_up.Text = "25";
            this.txtnhietdocao_up.TextChanged += new System.EventHandler(this.txtnhietdocao_up_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(321, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(429, 38);
            this.label1.TabIndex = 122;
            this.label1.Text = "Hệ Thống Nuôi Cá Tự Động";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cboluongthucan);
            this.groupBox2.Controls.Add(this.txtthucan_hienthi);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtgiochoan_up);
            this.groupBox2.Controls.Add(this.butthucan_up);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(23, 60);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(402, 294);
            this.groupBox2.TabIndex = 120;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thức Ăn";
            // 
            // cboluongthucan
            // 
            this.cboluongthucan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboluongthucan.FormattingEnabled = true;
            this.cboluongthucan.Location = new System.Drawing.Point(218, 50);
            this.cboluongthucan.Name = "cboluongthucan";
            this.cboluongthucan.Size = new System.Drawing.Size(121, 30);
            this.cboluongthucan.TabIndex = 113;
            this.cboluongthucan.Text = "Vừa";
            this.cboluongthucan.SelectedIndexChanged += new System.EventHandler(this.cboluongthucan_SelectedIndexChanged);
            // 
            // txtthucan_hienthi
            // 
            this.txtthucan_hienthi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtthucan_hienthi.Location = new System.Drawing.Point(218, 157);
            this.txtthucan_hienthi.Name = "txtthucan_hienthi";
            this.txtthucan_hienthi.Size = new System.Drawing.Size(121, 30);
            this.txtthucan_hienthi.TabIndex = 112;
            this.txtthucan_hienthi.TextChanged += new System.EventHandler(this.txtthucan_hienthi_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(19, 161);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(175, 26);
            this.label8.TabIndex = 104;
            this.label8.Text = "Cảnh báo thức ăn";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(19, 106);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(140, 26);
            this.label10.TabIndex = 107;
            this.label10.Text = "Giờ cho cá ăn";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(19, 54);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(146, 26);
            this.label9.TabIndex = 106;
            this.label9.Text = "Lượng thức ăn";
            // 
            // txtgiochoan_up
            // 
            this.txtgiochoan_up.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtgiochoan_up.Location = new System.Drawing.Point(218, 102);
            this.txtgiochoan_up.Name = "txtgiochoan_up";
            this.txtgiochoan_up.Size = new System.Drawing.Size(121, 30);
            this.txtgiochoan_up.TabIndex = 108;
            this.txtgiochoan_up.Text = "8";
            this.txtgiochoan_up.TextChanged += new System.EventHandler(this.txtgiochoan_up_TextChanged);
            // 
            // butthucan_up
            // 
            this.butthucan_up.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butthucan_up.Location = new System.Drawing.Point(127, 225);
            this.butthucan_up.Name = "butthucan_up";
            this.butthucan_up.Size = new System.Drawing.Size(112, 45);
            this.butthucan_up.TabIndex = 105;
            this.butthucan_up.Text = "Cập nhật";
            this.butthucan_up.UseVisualStyleBackColor = true;
            this.butthucan_up.Click += new System.EventHandler(this.butthucan_up_Click);
            // 
            // serCOM
            // 
            this.serCOM.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serCOM_DataReceived);
            // 
            // butpage3
            // 
            this.butpage3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butpage3.Location = new System.Drawing.Point(1210, 257);
            this.butpage3.Name = "butpage3";
            this.butpage3.Size = new System.Drawing.Size(89, 47);
            this.butpage3.TabIndex = 126;
            this.butpage3.Text = "page 3";
            this.butpage3.UseVisualStyleBackColor = true;
            this.butpage3.Click += new System.EventHandler(this.butpage3_Click);
            // 
            // butpage2
            // 
            this.butpage2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butpage2.Location = new System.Drawing.Point(1210, 181);
            this.butpage2.Name = "butpage2";
            this.butpage2.Size = new System.Drawing.Size(89, 47);
            this.butpage2.TabIndex = 127;
            this.butpage2.Text = "page 2";
            this.butpage2.UseVisualStyleBackColor = true;
            this.butpage2.Click += new System.EventHandler(this.button2_Click);
            // 
            // butExit
            // 
            this.butExit.BackColor = System.Drawing.Color.Red;
            this.butExit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butExit.Location = new System.Drawing.Point(1210, 95);
            this.butExit.Name = "butExit";
            this.butExit.Size = new System.Drawing.Size(89, 57);
            this.butExit.TabIndex = 130;
            this.butExit.Text = "Exit";
            this.butExit.UseVisualStyleBackColor = false;
            this.butExit.Click += new System.EventHandler(this.butExit_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // chart1
            // 
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(443, 80);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series3.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight;
            series3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea;
            series3.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(737, 341);
            this.chart1.TabIndex = 131;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(443, 434);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(737, 295);
            this.dataGridView1.TabIndex = 132;
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 3000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1210, 326);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 71);
            this.button1.TabIndex = 133;
            this.button1.Text = "Xuất excel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // giamsat1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1316, 760);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.butExit);
            this.Controls.Add(this.butpage2);
            this.Controls.Add(this.butpage3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "giamsat1";
            this.Text = "Form2";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.giamsat1_FormClosed);
            this.Load += new System.EventHandler(this.giamsat1_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtnhietdothap_up;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button butnhietdo_up;
        private System.Windows.Forms.TextBox txtnhietdocao_up;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cboluongthucan;
        private System.Windows.Forms.TextBox txtthucan_hienthi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtgiochoan_up;
        private System.Windows.Forms.Button butthucan_up;
        private System.IO.Ports.SerialPort serCOM;
        private System.Windows.Forms.Button butpage3;
        private System.Windows.Forms.Button butpage2;
        private System.Windows.Forms.Button butExit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbtrangthai;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label txtTemp;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button button1;
    }
}