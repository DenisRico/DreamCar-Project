using System;
using System.Collections.Generic;
using System.Text;
using Dream.Interfaces.Services;
using Dream.DataAccess.Context;
using Dream.DataAccess.Models.Models;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace Dream.BusinessLogic.Services.Car
{
    public class CarService : ICarService 
    {
        private readonly ApplicationContext _contextFactory;
        
        public CarService(ApplicationContext contextFactory)
        {
            _contextFactory = contextFactory;
        }

        public async Task AddAsync(DataAccess.Models.Models.Car car)
        {
            using var context = _contextFactory;

            await context.Cars.AddAsync(car).ConfigureAwait(false);
            
            await context.SaveChangesAsync().ConfigureAwait(false);


        }

        public async Task DeleteAsync(int id)
        {
            var context = _contextFactory;

            var entity = await context.Cars.FirstOrDefaultAsync(item => item.Id.Equals(id))
                .ConfigureAwait(false);

            if (entity == null) return;

            context.Cars.Remove(entity);

            await context.SaveChangesAsync().ConfigureAwait(false);
        }

        public async Task<IEnumerable<DataAccess.Models.Models.Car>> GetAsync()
        {
            var context = _contextFactory.Cars;

            await context.ToListAsync().ConfigureAwait(false);
            
            return context;
        }

        public async Task UpdateAsync(DataAccess.Models.Models.Car car)
        {
            var context = _contextFactory;

            var entity = await context.Cars.FirstOrDefaultAsync(item => item.Id.Equals(car.Id))
                .ConfigureAwait(false);

            if (entity == null) return;
            
            entity = car;
            
            context.Cars.Update(entity);

            await context.SaveChangesAsync().ConfigureAwait(false);
            
        }
    }
}
