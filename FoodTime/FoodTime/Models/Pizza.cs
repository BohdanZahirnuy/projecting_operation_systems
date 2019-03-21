using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodTime.Models
{
    public class Pizza: Food
    {
        public int Diameter { get; set; }

        public Pizza()
        {
            base.Name = "No data";
            base.Componets = "No data";
            base.Weight = 0;
            base.Category = "Pizza";
            base.Price = 0.0;
            Diameter = 0;
        }
    }
}
