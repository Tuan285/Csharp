using QuanLiCafe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiCafe.DAO
{
    public class TableDAO
    {
        private static TableDAO instance;

        public static TableDAO Instantce        // singer talk
        {
            get
            {
                if (instance == null)
                {
                    instance = new TableDAO();
                }
                return TableDAO.instance;
            }
            private set 
            {
                TableDAO.instance = value;
            }
        }

        public static int TableWidth = 100;
        public static int TableHeight = 100;

        public TableDAO() { }

        public List<Table> LoadTableList()
        {
            List<Table> tableList = new List<Table>();

            string query = "select * from QuanLyCafe1.dbo.TableFood";

            DataTable data = DataProvider.Instantce.ExecuteQuery(query);

            foreach(DataRow item in data.Rows)
            {
                Table table = new Table(item);
                tableList.Add(table);

            }
            return tableList;
        }
    }
}
