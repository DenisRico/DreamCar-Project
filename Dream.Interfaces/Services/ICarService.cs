using System;
using System.Collections.Generic;
using System.Text;
using Dream.DataAccess.Models.Models;
using System.Threading.Tasks;

namespace Dream.Interfaces.Services
{
    public interface ICarService
    {
        Task<IEnumerable<Car>> GetAsync();
        
        Task AddAsync(Car car);

        Task UpdateAsync(Car car);

        Task DeleteAsync(int id);
    }
}
