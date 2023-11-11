using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiCafe.DTO
{
    public class MenuDTO
    {

        public MenuDTO(string foodName , int counts , float price , float totalPrice = 0)   // default total price  = 0
        {
            this.foodName= foodName;
            this.counts = counts;
            this.price = price;
            this.totalPrice = totalPrice;
        }


        private string foodName;
        private int counts;
        private float price;
        private float totalPrice;

        public string FoodName { get => foodName; set => foodName = value; }
        public int Counts { get => counts; set => counts = value; }
        public float Price { get => price; set => price = value; }
        public float TotalPrice { get => totalPrice; set => totalPrice = value; }
    }
}
