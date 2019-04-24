using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodTime.Data.Models;

namespace Services.Dto
{
    public class OrderDto
    {
        public int Id { get; set; }
        public Food Dish { get; set; }
        public string Number { get; set; }
        public string Address { get; set; }
        public int Quantity { get; set; }

        public OrderDto(Order obj)
        {
            this.Id = obj.Id;
            this.Dish = obj.Dish;
            this.Number = obj.Number;
            this.Address = obj.Address;
            this.Quantity = obj.Quantity;
        }
    }
}
