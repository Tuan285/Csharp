using QuanLiCafe.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiCafe.DAO
{
    public class BillDAO
    {
        private static BillDAO instance;

        public static BillDAO Instance
        {
            get 
            {
                if (instance == null)
                {
                    instance = new BillDAO();
                }
                return instance; 
            }
            private set 
            { 
                instance = value; 
            }
        }
    
        private BillDAO() { }

        public int GetUnCheckBillIdByTableID(int id)       // -1 la ko co id phu hop
        {
            DataTable data = DataProvider.Instantce.ExecuteQuery("select * from QuanLyCafe1.dbo.Bill where idTable = "+ id +" and trangThai = 0");

            if (data.Rows.Count > 0)
            {
                BillDTO bill = new BillDTO(data.Rows[0]);
                return bill.IdTable;
            }
            return -1;
        }

    }
}
