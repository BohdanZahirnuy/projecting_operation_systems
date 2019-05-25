using System;
using System.Collections.Generic;
using System.Text;

namespace FoodTime.Data.Models
{
    public class CartM
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public int FoodId { get; set; }
        public int Quanity { get; set; }
    }
}