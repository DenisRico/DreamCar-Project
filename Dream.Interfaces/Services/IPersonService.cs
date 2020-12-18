using System;
using System.Collections.Generic;
using System.Text;
using Dream.DataAccess.Models.Models;
using System.Threading.Tasks;

namespace Dream.Interfaces.Services
{
    public interface IPersonService
    {
        Task<IEnumerable<Person>> GetAsync();

    }
}
