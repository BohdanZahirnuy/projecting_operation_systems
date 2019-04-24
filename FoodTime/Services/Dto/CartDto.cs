using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodTime.Data.Models;

namespace Services.Dto
{
    public class CartDto
    {
        public int ID { get; set; }
        public List<Order> OrderList { get; set; }
        public DateTime Date { get; set; }

        public CartDto(Cart obj)
        {
            this.ID = obj.ID;
            this.OrderList = obj.OrderList;
            this.Date = obj.Date;
        }
    }
}
