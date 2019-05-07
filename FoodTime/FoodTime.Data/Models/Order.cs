using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodTime.Data.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string Info { get; set; }
        public string User { get; set; }
        public string Address { get; set; }
        public DateTime Date { get; set; }
        
    }
}