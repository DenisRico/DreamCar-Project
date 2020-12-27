using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using Dream.BusinessLogic.Models.Profiles;
using TestAngular5.Profiles;

namespace TestAngular5.Configuration
{
    /// <summary>
    /// Конфигурация AutoMapper
    /// </summary>
    public static class AutoMapperConfig
    {
        /// <summary>
        /// Регистрация AutoMapper
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection RegisterAutoMapper(this IServiceCollection services)
        {
            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new PrMapperProfile());
                mc.AddProfile(new BlMapperProfile());
            });

            var mapper = mappingConfig.CreateMapper();
            services.AddSingleton(mapper);

            return services;
        }
    }
}
