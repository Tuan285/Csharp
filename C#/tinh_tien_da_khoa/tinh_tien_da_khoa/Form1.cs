using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tinh_tien_da_khoa
{
    public partial class Form1 : Form
    {
        int caovoi, taytrang, nhorang, tramrang;
        public Form1()
        {
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            String user = tbTenKhachhang.Text.ToString();
            if (user != "")
            {
                panel1.Enabled = true;
            }
            else
            {
                panel1.Enabled = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btTinhTien_Click(object sender, EventArgs e)
        {
            int tongtien = caovoi + taytrang+ nhorang + tramrang;
            tbTongTien.Text = tongtien.ToString();
        }

        private void cbCaoVoi_CheckedChanged(object sender, EventArgs e)
        {
            
            if (cbCaoVoi.Checked)
            {
                caovoi = int.Parse(lbTienCaoVoi.Text);
            }
            else { caovoi = 0; }
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(
                "Bạn có muốn thoát chương trình không ?", 
                "Thông Báo!!", 
                MessageBoxButtons.OKCancel, 
                MessageBoxIcon.Question);
            if (dialogResult == DialogResult.OK)
            {
                Close();
            }
            
        }

        private void nUDTramrang_ValueChanged(object sender, EventArgs e)
        {
            tramrang = (int)nUDTramrang.Value * int.Parse(lbTienTramRang.Text);
        }

        private void cbTayTrang_CheckedChanged(object sender, EventArgs e)
        {
            
            if (cbTayTrang.Checked)
            {
                taytrang = int.Parse(lbTienTayTrang.Text);
            }
            else { taytrang = 0; }
        }

        private void nUDNhoRang_ValueChanged(object sender, EventArgs e)
        {
            nhorang = (int)nUDNhoRang.Value * int.Parse(lbTienNhoRang.Text);
        }

    }
}
