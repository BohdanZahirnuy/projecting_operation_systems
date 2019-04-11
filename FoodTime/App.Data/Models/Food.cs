using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppData.Models
{
    public abstract class Food
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public string Componets { get; set; }
        public int Weight { get; set; }
        public double Price { get; set; }

        public Food()
        {

        }
    }
}
