namespace tinh_tien_da_khoa
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btTinhTien = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btThoat = new System.Windows.Forms.Button();
            this.tbTenKhachhang = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.tbTongTien = new System.Windows.Forms.TextBox();
            this.lbTienTramRang = new System.Windows.Forms.Label();
            this.lbTienNhoRang = new System.Windows.Forms.Label();
            this.nUDTramrang = new System.Windows.Forms.NumericUpDown();
            this.nUDNhoRang = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbTienTayTrang = new System.Windows.Forms.Label();
            this.lbTienCaoVoi = new System.Windows.Forms.Label();
            this.cbTayTrang = new System.Windows.Forms.CheckBox();
            this.cbCaoVoi = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDTramrang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDNhoRang)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Phan Mem Tinh Tien Da Khoa";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ten Khach Hang";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btTinhTien
            // 
            this.btTinhTien.Location = new System.Drawing.Point(17, 249);
            this.btTinhTien.Name = "btTinhTien";
            this.btTinhTien.Size = new System.Drawing.Size(75, 23);
            this.btTinhTien.TabIndex = 15;
            this.btTinhTien.Text = "Tính Tiền";
            this.btTinhTien.UseVisualStyleBackColor = true;
            this.btTinhTien.Click += new System.EventHandler(this.btTinhTien_Click);
            // 
            // btXoa
            // 
            this.btXoa.Location = new System.Drawing.Point(98, 249);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(75, 23);
            this.btXoa.TabIndex = 16;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            // 
            // btThoat
            // 
            this.btThoat.Location = new System.Drawing.Point(179, 249);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(75, 23);
            this.btThoat.TabIndex = 17;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // tbTenKhachhang
            // 
            this.tbTenKhachhang.Location = new System.Drawing.Point(140, 52);
            this.tbTenKhachhang.Name = "tbTenKhachhang";
            this.tbTenKhachhang.Size = new System.Drawing.Size(100, 20);
            this.tbTenKhachhang.TabIndex = 0;
            this.tbTenKhachhang.Text = "tuan";
            this.tbTenKhachhang.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.tbTongTien);
            this.panel1.Controls.Add(this.lbTienTramRang);
            this.panel1.Controls.Add(this.lbTienNhoRang);
            this.panel1.Controls.Add(this.nUDTramrang);
            this.panel1.Controls.Add(this.nUDNhoRang);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.lbTienTayTrang);
            this.panel1.Controls.Add(this.lbTienCaoVoi);
            this.panel1.Controls.Add(this.cbTayTrang);
            this.panel1.Controls.Add(this.cbCaoVoi);
            this.panel1.Location = new System.Drawing.Point(15, 79);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(238, 164);
            this.panel1.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 132);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "Tổng Cộng";
            // 
            // tbTongTien
            // 
            this.tbTongTien.Location = new System.Drawing.Point(125, 125);
            this.tbTongTien.Name = "tbTongTien";
            this.tbTongTien.Size = new System.Drawing.Size(100, 20);
            this.tbTongTien.TabIndex = 25;
            // 
            // lbTienTramRang
            // 
            this.lbTienTramRang.AutoSize = true;
            this.lbTienTramRang.Location = new System.Drawing.Point(122, 97);
            this.lbTienTramRang.Name = "lbTienTramRang";
            this.lbTienTramRang.Size = new System.Drawing.Size(43, 13);
            this.lbTienTramRang.TabIndex = 24;
            this.lbTienTramRang.Text = "200000";
            // 
            // lbTienNhoRang
            // 
            this.lbTienNhoRang.AutoSize = true;
            this.lbTienNhoRang.Location = new System.Drawing.Point(122, 70);
            this.lbTienNhoRang.Name = "lbTienNhoRang";
            this.lbTienNhoRang.Size = new System.Drawing.Size(43, 13);
            this.lbTienNhoRang.TabIndex = 23;
            this.lbTienNhoRang.Text = "150000";
            // 
            // nUDTramrang
            // 
            this.nUDTramrang.Location = new System.Drawing.Point(80, 90);
            this.nUDTramrang.Name = "nUDTramrang";
            this.nUDTramrang.Size = new System.Drawing.Size(33, 20);
            this.nUDTramrang.TabIndex = 22;
            this.nUDTramrang.ValueChanged += new System.EventHandler(this.nUDTramrang_ValueChanged);
            // 
            // nUDNhoRang
            // 
            this.nUDNhoRang.Location = new System.Drawing.Point(80, 63);
            this.nUDNhoRang.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nUDNhoRang.Name = "nUDNhoRang";
            this.nUDNhoRang.Size = new System.Drawing.Size(33, 20);
            this.nUDNhoRang.TabIndex = 21;
            this.nUDNhoRang.ValueChanged += new System.EventHandler(this.nUDNhoRang_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Trám Răng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Nhổ Răng";
            // 
            // lbTienTayTrang
            // 
            this.lbTienTayTrang.AutoSize = true;
            this.lbTienTayTrang.Location = new System.Drawing.Point(116, 39);
            this.lbTienTayTrang.Name = "lbTienTayTrang";
            this.lbTienTayTrang.Size = new System.Drawing.Size(49, 13);
            this.lbTienTayTrang.TabIndex = 18;
            this.lbTienTayTrang.Text = "1500000";
            // 
            // lbTienCaoVoi
            // 
            this.lbTienCaoVoi.AutoSize = true;
            this.lbTienCaoVoi.Location = new System.Drawing.Point(122, 16);
            this.lbTienCaoVoi.Name = "lbTienCaoVoi";
            this.lbTienCaoVoi.Size = new System.Drawing.Size(43, 13);
            this.lbTienCaoVoi.TabIndex = 17;
            this.lbTienCaoVoi.Text = "100000";
            // 
            // cbTayTrang
            // 
            this.cbTayTrang.AutoSize = true;
            this.cbTayTrang.Location = new System.Drawing.Point(14, 35);
            this.cbTayTrang.Name = "cbTayTrang";
            this.cbTayTrang.Size = new System.Drawing.Size(75, 17);
            this.cbTayTrang.TabIndex = 16;
            this.cbTayTrang.Text = "Tẩy Trắng";
            this.cbTayTrang.UseVisualStyleBackColor = true;
            this.cbTayTrang.CheckedChanged += new System.EventHandler(this.cbTayTrang_CheckedChanged);
            // 
            // cbCaoVoi
            // 
            this.cbCaoVoi.AutoSize = true;
            this.cbCaoVoi.Location = new System.Drawing.Point(14, 12);
            this.cbCaoVoi.Name = "cbCaoVoi";
            this.cbCaoVoi.Size = new System.Drawing.Size(63, 17);
            this.cbCaoVoi.TabIndex = 15;
            this.cbCaoVoi.Text = "Cạo Vôi";
            this.cbCaoVoi.UseVisualStyleBackColor = true;
            this.cbCaoVoi.CheckedChanged += new System.EventHandler(this.cbCaoVoi_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btThoat;
            this.ClientSize = new System.Drawing.Size(273, 289);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btTinhTien);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbTenKhachhang);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDTramrang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDNhoRang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btTinhTien;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.TextBox tbTenKhachhang;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbTongTien;
        private System.Windows.Forms.Label lbTienTramRang;
        private System.Windows.Forms.Label lbTienNhoRang;
        private System.Windows.Forms.NumericUpDown nUDTramrang;
        private System.Windows.Forms.NumericUpDown nUDNhoRang;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbTienTayTrang;
        private System.Windows.Forms.Label lbTienCaoVoi;
        private System.Windows.Forms.CheckBox cbTayTrang;
        private System.Windows.Forms.CheckBox cbCaoVoi;
    }
}

