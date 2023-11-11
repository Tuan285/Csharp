using QuanLiCafe.DAO;
using QuanLiCafe.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiCafe
{
    public partial class fTableManager : Form
    {
        public fTableManager()
        {
            InitializeComponent();
            LoadTableFood();
        }

        #region Method
        void LoadTableFood()
        {
            List<DTO.Table> tableList = TableDAO.Instantce.LoadTableList();

            foreach(DTO.Table item in tableList)
            {
                Button btn = new Button();

                btn.Width = TableDAO.TableWidth;
                btn.Height = TableDAO.TableHeight;

                btn.Text= item.Name + Environment.NewLine + item.Status + Environment.NewLine;

                btn.Tag = item;

                btn.Click += Btn_Click;
                
                switch(item.Status)
                {
                    case "Trống":
                            btn.BackColor =  Color.Aqua; break;
                    default: btn.BackColor = Color.Red; break;
                }
                flpTable.Controls.Add(btn);

            }
        }
        
        void ShowBill(int id)
        {
            lstVBill.Items.Clear();

             List<BillInforDTO> listbillInfor = BillInforDAO.Instance.GetListBillInfor(BillDAO.Instance.GetUnCheckBillIdByTableID(id));
            
            foreach(BillInforDTO item in listbillInfor)
            {
                ListViewItem listViewItem= new ListViewItem(item.IdFood.ToString());

                listViewItem.SubItems.Add(item.Counts.ToString());

                lstVBill.Items.Add(listViewItem);
            }
        }

        #endregion


        #region Events

        private void Btn_Click(object sender, EventArgs e)
        {
            int idTable = ((sender as Button).Tag as Table).ID;
            
            ShowBill(idTable);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btThanhToan_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAccount fAccount= new fAccount();
            this.Close();
            fAccount.ShowDialog();
            this.Show();
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAdmin fAdmin = new fAdmin();
            fAdmin.ShowDialog();
        }
        #endregion
    }
}
