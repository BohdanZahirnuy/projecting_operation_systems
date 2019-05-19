using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace FoodTime.Models
{
    public class CommentViewModel
    {
        [Required]
        public int FoodId { get; set; }
        [Required]
        public string Message { get; set; }
        public DateTime Date { get; set; }
    }
}
