using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Dream.DataAccess.Models.Models;

namespace Dream.DataAccess.Context
{
    public class DatabaseContext:DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer(@"Server=DESKTOP-06HJETK\\SQLEXPRESS;Database=productsdb;Trusted_Connection=True;");
        //}

        public DbSet<Car> Cars { get; set; }
        public DbSet<Person> Persons { get; set; }
    }
}
