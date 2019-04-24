using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodTime.Data.Models;

namespace Services.Dto
{
    public class CommentDto
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public string DishId { get; set; }
        public string Owner { get; set; }
        public DateTime Date { get; set; }

        public CommentDto(Comment obj)
        {
            this.Id = obj.Id;
            this.Content = obj.Content;
            this.DishId = obj.DishId;
            this.Owner = obj.Owner;
            this.Date = obj.Date;
        }
    }
}
