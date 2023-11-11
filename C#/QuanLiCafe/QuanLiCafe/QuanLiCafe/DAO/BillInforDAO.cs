using QuanLiCafe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiCafe.DAO
{
    public class BillInforDAO
    {
        private static BillInforDAO instance;

        public static BillInforDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BillInforDAO();
                }
                return instance;
            }
            private set
            {
                instance = value;
            }
        }

        public BillInforDAO() { }

        public List<BillInforDTO> GetListBillInfor(int id) 
        {
            List<BillInforDTO> list = new List<BillInforDTO>();

            DataTable data = DataProvider.Instantce.ExecuteQuery("select * from QuanLyCafe1.dbo.BillInfo where idBill = " + id);

            foreach (DataRow row in data.Rows)
            {
                BillInforDTO infor = new BillInforDTO(row);

                list.Add(infor);
            }

            return list;
        }
    }
}
