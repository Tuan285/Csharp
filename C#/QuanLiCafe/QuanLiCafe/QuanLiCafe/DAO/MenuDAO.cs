using QuanLiCafe.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiCafe.DAO
{
    public class MenuDAO
    {
        private static MenuDAO instance;

        public static MenuDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new MenuDAO();
                }
                return instance;
            }
            private set
            {
                instance = value;
            }
        }

        public MenuDAO() { }

        public List<MenuDTO> GetListMenuByTable (string idTable) 
        {
            List<MenuDTO> list = new List<MenuDTO>();

            return list;
        }
    }
}
