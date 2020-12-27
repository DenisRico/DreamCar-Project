using System.Collections.Generic;
using System.Threading.Tasks;

namespace Dream.Interfaces.Services
{
    public interface IPersonService
    {
        Task<IEnumerable<Dream.BusinessLogic.Models.PersonModels.Person>> GetAsync();

    }
}
