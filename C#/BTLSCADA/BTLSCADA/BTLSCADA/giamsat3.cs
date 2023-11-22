using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTLSCADA
{
    public partial class giamsat3 : Form
    {
        public giamsat3()
        {
            InitializeComponent();
        }

        private void butpage1_Click(object sender, EventArgs e)
        {
            this.Hide();
            giamsat1 f = new giamsat1();
            f.ShowDialog();
            f = null;
            this.Show();
        }

        private void butpage2_Click(object sender, EventArgs e)
        {
            this.Hide();
            giamsat2 f = new giamsat2();
            f.ShowDialog();
            f = null;
            this.Show();
        }
    }
}
