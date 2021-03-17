using System;
using Microsoft.EntityFrameworkCore;
using Dream.DataAccess.Models.Models;
using Dream.DataAccess.Models.Configuration;

namespace Dream.DataAccess.Context
{
    public class DatabaseContext:DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options)
            : base(options)
        {
            //Database.EnsureDeleted();
            try
            {
                Database.EnsureCreated();
            }
            catch (Exception e) {
                e.GetBaseException();
            }
            //Database.EnsureCreated();
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer(@"Server=DESKTOP-06HJETK\\SQLEXPRESS;Database=productsdb;Trusted_Connection=True;");
        //}

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyModelConfiguration();
        }

        public DbSet<Car> Cars { get; set; }
        public DbSet<Person> Persons { get; set; }
    }
}
