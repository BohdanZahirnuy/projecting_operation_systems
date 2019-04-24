using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodTime.DTO
{
    public class CommentDTO
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public string DishId { get; set; }
        public string Owner { get; set; }
        public DateTime Date { get; set; }
    }
}
