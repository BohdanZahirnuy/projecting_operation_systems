using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodTime.DTO
{
    public class FoodDTO
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
