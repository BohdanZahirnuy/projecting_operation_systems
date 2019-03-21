using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodTime.Models
{
    public abstract class Food
    {
        public string Name { get; set; }
        public string Category { get; set; }
        public string Componets { get; set; }
        public int Weight { get; set; }
        public double Price { get; set; }
    }
}
