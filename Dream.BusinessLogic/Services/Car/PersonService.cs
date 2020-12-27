using System.Collections.Generic;
using Dream.Interfaces.Services;
using Dream.DataAccess.Context;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AutoMapper;

namespace Dream.BusinessLogic.Services.Person
{
    public class PersonService:IPersonService
    {
        private readonly DatabaseContext _contextFactory;
        private readonly IMapper _mapper;

        public PersonService(DatabaseContext contextFactory, IMapper mapper)
        {
            _contextFactory = contextFactory;
            _mapper = mapper;
        }

        public async Task<IEnumerable<Dream.BusinessLogic.Models.PersonModels.Person>> GetAsync()
        {


            var context = _contextFactory.Persons;

            await context.ToListAsync().ConfigureAwait(false);

            var Items = _mapper.Map<IEnumerable<Dream.BusinessLogic.Models.PersonModels.Person>>(context);

            return Items;
        }
    }
}
