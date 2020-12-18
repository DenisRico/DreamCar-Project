using System;
using Microsoft.Extensions.DependencyInjection;
using Dream.Interfaces.Services;
using Dream.BusinessLogic.Services.Car;
using Dream.BusinessLogic.Services.Person;

namespace Dream.DependencyInjection
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection RegisterBusinessLogicServices(this IServiceCollection services)
        {
            ///service car
            services.AddTransient<ICarService, CarService>();
            services.AddTransient<IPersonService, PersonService>();

            return services;
        }
    }
}
