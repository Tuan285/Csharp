using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiCafe.DTO
{
    public class BillInforDTO
    {
        public BillInforDTO(int id, int idBill, int idFood, int counts)
        {
            this.id = id;
            this.idBill = idBill;
            this.idFood = idFood;
            this.counts = counts;
        }
        public BillInforDTO(DataRow rows)
        {
            this.id = (int)rows["id"];
            this.idBill =(int) rows["idBill"];
            this.idFood = (int)rows["idFood"];
            this.counts = (int)rows["counts"];
        }
        private int id;
        private int idBill;
        private int idFood;
        private int counts;

        public int Id { get => id; set => id = value; }
        public int IdBill { get => idBill; set => idBill = value; }
        public int IdFood { get => idFood; set => idFood = value; }
        public int Counts { get => counts; set => counts = value; }
        
    }
}
