using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Services.Filters
{
    class CommentFilter
    {
        public string Name { get; set; }
        public int Id { get; set; }
    }
}
