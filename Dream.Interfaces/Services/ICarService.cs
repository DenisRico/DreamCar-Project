using System.Collections.Generic;
using Dream.BusinessLogic.Models;
using System.Threading.Tasks;

namespace Dream.Interfaces.Services
{
    public interface ICarService
    {
        Task<IEnumerable<Dream.BusinessLogic.Models.CarModels.Car>> GetAsync();
        
        Task AddAsync(Dream.BusinessLogic.Models.CarModels.Car car);

        Task UpdateAsync(Dream.BusinessLogic.Models.CarModels.Car car);

        Task DeleteAsync(int id);
    }
}
