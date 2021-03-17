using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Dream.DataAccess.Models.Models
{
    public class Car
    {
        public int Id { get; set; }   //id
        public string Name { get; set; }    // name 
        public int Year { get; set; } // year
        public string Condition { get; set; }  // condition 
        public string FuelType { get; set; }  // Fuel type
        public string Color { get; set; }  // color
        public int Price { get; set; }  // price
        public string Description { get; set; }  // definition 
        public string Image { get; set; }  // image
    }

    internal class CarMap : IEntityTypeConfiguration<Car>
    {
        public static CarMap Instance = new CarMap();

        public void Configure(EntityTypeBuilder<Car> builder)
        {
            builder.HasKey(item => item.Id);

            builder.Property(item => item.Name).IsRequired().HasMaxLength(10);

            builder.Property(item => item.Year).IsRequired();

            builder.Property(item => item.Condition).IsRequired();

            builder.Property(item => item.FuelType).IsRequired();

            builder.Property(item => item.Color).IsRequired();

            builder.Property(item => item.Price).IsRequired();

            builder.Property(item => item.Description).IsRequired();

            builder.Property(item => item.Image).IsRequired();

            
        }
    }
}
