using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodTime.Data.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public string DishId { get; set; }
        public string Owner { get; set; }
        public DateTime Date { get; set; }

        public Comment()
        {
            Content = "";
            DishId = "";
            Owner = "";
            Date = new DateTime();
        }

        public Comment(string _content, Food dish,  DateTime _date)
        {
            Content = _content;
            DishId = dish.Name;
           
            Date = _date;
        }
    }
}