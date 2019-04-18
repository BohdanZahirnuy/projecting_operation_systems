using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodTime.Data.Models
{
    public class Order
    {
        public int Id { get; set; }
        public Food Dish { get; set; }
        public string Number { get; set; }
        public string Address { get; set; }
        public int Quantity { get; set; }
    }
}