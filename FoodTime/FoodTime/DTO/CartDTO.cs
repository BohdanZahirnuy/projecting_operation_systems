using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodTime.Data.Models;
namespace FoodTime.DTO
{
    public class CartDTO
    {
        public int ID { get; set; }
        public List<Order> OrderList { get; set; }
        public DateTime Date { get; set; }
    }
}
