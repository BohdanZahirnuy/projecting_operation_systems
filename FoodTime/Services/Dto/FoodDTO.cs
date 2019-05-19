using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodTime.Data.Models;

namespace Services.Dto
{
    public class FoodDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public string Componets { get; set; }
        public int Weight { get; set; }
        public double Price { get; set; }
        public string ExtraInfo { get; set; }

    }
}
