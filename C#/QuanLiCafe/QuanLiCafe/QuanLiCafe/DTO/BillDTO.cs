using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiCafe.DTO
{
    public class BillDTO
    {
        public BillDTO(int id , DateTime? DateCheckIn, DateTime? DateCheckOut, int status)
        {
            this.idTable = id;
            this.DateCheckIn = DateCheckIn;
            this.DateCheckOut = DateCheckOut;
            this.status = status;
        }

        public BillDTO ( DataRow row)
        {
            this.idTable = (int) row["id"];
            this.DateCheckIn = (DateTime?) row["DateCheckIn"];
            this.DateCheckOut = (DateTime?) row["DateCheckOut"];
            this.status = (int) row["trangThai"];
        }


        private DateTime? DateCheckIn;

        private DateTime? DateCheckOut;

        private int idTable;

        private int status;
        public DateTime? DateCheckIn1 { get => DateCheckIn; set => DateCheckIn = value; }

        public DateTime? DateCheckOut1 { get => DateCheckOut; set => DateCheckOut = value; }

        public int IdTable { get => idTable; set => idTable = value; }

        public int Status { get => status; set => status = value; }

        

    }
}
