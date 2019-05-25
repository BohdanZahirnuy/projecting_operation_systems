using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Dto
{
    public class CartMDto
    {
        public int Id { get; set; }
        public int FoodId { get; set; }
        public string UserId { get; set; }
        public int Quanity { get; set; }
    }
}

