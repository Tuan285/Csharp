using QuanLiCafe.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiCafe
{
    public partial class fAdmin : Form
    {
        public fAdmin()
        {
            InitializeComponent();
            //LoadAccountList();
        }
        void LoadAccountList()
        {
            //string query = "select * from dbo.Account";         // lenh truy van database

            //string query = "exec dbo.USP_GetlListAccountByUserName @userName";         // lenh truy van database

            //dtgTaiKhoan.DataSource = DataProvider.Instantce.ExecuteQuery(query, new object[] {"Staff"} );
        }
        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void panel16_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabTaiKhoan_Click(object sender, EventArgs e)
        {

        }
    }
}
