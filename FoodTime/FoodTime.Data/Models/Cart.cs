using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace FoodTime.Data.Models
{
    public class Cart
    {
        public int ID { get; set; }
        public List<Order> OrderList { get; set; }
        public DateTime Date { get; set; }

        public Cart()
        {
            OrderList = new List<Order>();
            Date = new DateTime();
        }

        public double GetTotalPrice()
        {
            double sum = 0.0;
            for(int i=0; i<OrderList.Count; i++)
            {
                sum += OrderList[i].GetTotalPrice();
            }
            return sum;
        }
    }
}