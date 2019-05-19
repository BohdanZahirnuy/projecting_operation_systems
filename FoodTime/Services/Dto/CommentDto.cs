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
        public string Message { get; set; }
        public DateTime Date { get; set; }
        public int FoodId { get; set; }
    }
}
