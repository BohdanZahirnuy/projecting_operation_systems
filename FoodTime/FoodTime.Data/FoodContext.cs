using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;

namespace FoodTime.Data
{
    public class FoodContext : DbContext
    {
        public FoodContext() 
        {
            

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=aspnet-FoodTime-A008C036-0394-4387-8762-5247BC8B3DDE;Trusted_Connection=True;MultipleActiveResultSets=true");

            }

        }
           

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
        //entities
        public DbSet<FoodTime.Data.Models.Food> Food { get; set; }

    }
}
