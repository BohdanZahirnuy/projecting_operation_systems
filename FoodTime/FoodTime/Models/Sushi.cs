using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace FoodTime.Models
{
    public class Sushi: Food
    {
        public string SubCategory { get; set; }

        public Sushi()
        {
            base.Name = "No data";
            base.Componets = "No data";
            base.Weight = 0;
            base.Category = "Sushi";
            base.Price = 0.0;
            SubCategory = "No data";
        }
    }
}
