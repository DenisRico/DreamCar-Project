using Microsoft.EntityFrameworkCore;
using Dream.DataAccess.Models.Models;

namespace Dream.DataAccess.Models.Configuration
{
    public static class ModelBuilderExtension
    {
        public static ModelBuilder ApplyModelConfiguration(this ModelBuilder builder)
        {

            builder.ApplyConfiguration(CarMap.Instance);

            builder.ApplyConfiguration(PersonMap.Instance);

            return builder;
        }
    }
}
