using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FoodTime.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
       
        public DbSet<FoodTime.Models.User> User { get; set; }
        public DbSet<FoodTime.Models.Comment> Comment{ get; set; }
        public DbSet<FoodTime.Models.Pizza> Pizza { get; set; }
        public DbSet<FoodTime.Models.Sushi> Sushi { get; set; }


    }
}
    