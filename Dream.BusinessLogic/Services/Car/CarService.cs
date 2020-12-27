using System.Collections.Generic;
using Dream.Interfaces.Services;
using Dream.DataAccess.Context;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Dream.BusinessLogic.Models;
using AutoMapper;


namespace Dream.BusinessLogic.Services.Car
{
    public class CarService : ICarService 
    {
        private readonly DatabaseContext _contextFactory;
        private readonly IMapper _mapper;

        public CarService(DatabaseContext contextFactory, IMapper mapper)
        {
            _contextFactory = contextFactory;
            _mapper = mapper;
        }

        public async Task AddAsync(Dream.BusinessLogic.Models.CarModels.Car car)
        {
            var entity = _mapper.Map<Dream.DataAccess.Models.Models.Car>(car);

            using var context = _contextFactory;

            await context.Cars.AddAsync(entity).ConfigureAwait(false);
            
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

        public async Task<IEnumerable<Dream.BusinessLogic.Models.CarModels.Car>> GetAsync()
        {
            var context = _contextFactory.Cars;

            await context.ToListAsync().ConfigureAwait(false);

            var Items = _mapper.Map<IEnumerable<Dream.BusinessLogic.Models.CarModels.Car>>(context);
            
            return Items;
        }

        public async Task UpdateAsync(Dream.BusinessLogic.Models.CarModels.Car car)
        {
            var context = _contextFactory;

            var entity = await context.Cars.FirstOrDefaultAsync(item => item.Id.Equals(car.Id))
                .ConfigureAwait(false);

            if (entity == null) return;
            
            entity.Image = car.Image;
            
            
            context.Cars.Update(entity);

            await context.SaveChangesAsync().ConfigureAwait(false);
            
        }
    }
}
