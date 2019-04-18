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
            Database.EnsureCreated();
        }
     
        public DbSet<FoodTime.Data.Models.Comment> Comment{ get; set; }
        public DbSet<FoodTime.Data.Models.Pizza> Pizza { get; set; }
        public DbSet<FoodTime.Data.Models.Sushi> Sushi { get; set; }


    }
}
    