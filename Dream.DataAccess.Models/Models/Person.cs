using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Dream.DataAccess.Models.Models
{
    public class Person
    {
        public int Id { get; set; }   //id
        public string Name { get; set; }    // name 
        public string Position { get; set; } // company
        public string Image { get; set; }  // price
        public string Profile { get; set; }  // price
    }

    internal class PersonMap : IEntityTypeConfiguration<Person>
    {
        public static PersonMap Instance = new PersonMap();

        public void Configure(EntityTypeBuilder<Person> builder)
        {
            builder.HasKey(item => item.Id);

            builder.Property(item => item.Name).IsRequired().HasMaxLength(10);

            builder.Property(item => item.Position).IsRequired();

            builder.Property(item => item.Image).IsRequired();

            builder.Property(item => item.Profile).IsRequired();

        
        }
    }
}
