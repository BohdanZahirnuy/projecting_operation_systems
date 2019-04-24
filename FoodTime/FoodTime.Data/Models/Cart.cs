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
    }
}