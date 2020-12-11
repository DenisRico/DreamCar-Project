using System;
using Microsoft.Extensions.DependencyInjection;
using Dream.Interfaces.Services;
using Dream.BusinessLogic.Services.Car;

namespace Dream.DependencyInjection
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection RegisterBusinessLogicServices(this IServiceCollection services)
        {
            ///service car
            services.AddTransient<ICarService, CarService>();

            return services;
        }
    }
}
