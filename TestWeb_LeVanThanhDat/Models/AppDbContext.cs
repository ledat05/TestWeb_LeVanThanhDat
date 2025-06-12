using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestWeb_LeVanThanhDat.Models
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Book> Books { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Book>().HasData(
                   new Book { Id = 1, Title = "TÂM", Price = 700, Quantity = 1 },
                   new Book { Id = 2, Title = "ASP.NET", Price = 800, Quantity = 1 },
                   new Book { Id = 3, Title = "PHP", Price = 750, Quantity = 1 },
                   new Book { Id = 4, Title = "JavaScript", Price = 600, Quantity = 1 },
            new Book { Id = 5, Title = "Trình là gì ?", Price = 900, Quantity = 1 });
        }

    }
}


