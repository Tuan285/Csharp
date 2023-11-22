using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTLSCADA
{

    public partial class dangnhap : Form
    {
        string[] ports;
        string com;
        string tentaikhoan = "nuoicatudong";
        string matkhau = "123";
        public dangnhap()
        {
            InitializeComponent();
        }

        private void butdangnhap_Click(object sender, EventArgs e)
        {
            if (KiemTraDangNhap(txttaikhoan.Text, txtmatkhau.Text))
            {
                giamsat1 f = new giamsat1();
                f.Show();
                this.Hide();
                f.dangxuat += F_dangxuat;
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng", "Lỗi");
                txttaikhoan.Focus();
            }    
        }

        private void F_dangxuat(object sender, EventArgs e)
        {
                
            (sender as giamsat1).isThoat = false;
            (sender as giamsat1).Close();
            this.Show();
        }
        bool KiemTraDangNhap(string tentaikhoan, string matkhau)
        {
            if(tentaikhoan == this.tentaikhoan && matkhau == this.matkhau) 
            {
                return true;
            }
            return false;
        }
        private void butthoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dangnhap_Load(object sender, EventArgs e)
        {

        }
    }
}
