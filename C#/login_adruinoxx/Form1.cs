using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace login_adruinoxx
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void acessLogin_Click(object sender, EventArgs e)
        {
            SqlConnection myCon = new SqlConnection(@"Data Source=LAPTOP-8JB7NP47\SQLEXPRESS;Initial Catalog=Login_arduinoxx;Integrated Security=True");

            try
            {
                myCon.Open();
                string User = textBoxUser.Text;
                string Password = textBoxPassword.Text;
                string sql = "select *from table_login where username = '"+User+"' and password = '"+Password+"'";
                SqlCommand cmd = new SqlCommand(sql, myCon);
                SqlDataReader data = cmd.ExecuteReader();
                if (data.Read())
                {
                    MessageBox.Show("Login !!");
                }
                else
                {
                    MessageBox.Show("Login Failed !!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection failed !");
            };
        }
    }
}
