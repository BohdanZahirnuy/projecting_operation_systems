using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodTime.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public int DishId { get; set; }
        public string Owner { get; set; }
        public DateTime Date { get; set; }

        public Comment()
        {
            Content = "";
            DishId = 0;
            Owner = "";
            Date = new DateTime();
        }

        public Comment(string _content, Food dish, User usr, DateTime _date)
        {
            Content = _content;
            DishId = dish.Id;
            Owner = usr.Username;
            Date = _date;
        }
    }
}