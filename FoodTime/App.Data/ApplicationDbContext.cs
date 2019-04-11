using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AppData
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
       
        public DbSet<AppData.Models.Comment> Comment{ get; set; }
        public DbSet<AppData.Models.Pizza> Pizza { get; set; }
        public DbSet<AppData.Models.Sushi> Sushi { get; set; }


    }
}
    