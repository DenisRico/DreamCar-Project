using System;
using System.Collections.Generic;
using System.Text;
using Dream.Interfaces.Services;
using Dream.DataAccess.Context;
using Dream.DataAccess.Models.Models;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Dream.BusinessLogic.Services.Person
{
    public class PersonService:IPersonService
    {
        private readonly DatabaseContext _contextFactory;

        public PersonService(DatabaseContext contextFactory)
        {
            _contextFactory = contextFactory;
        }

        public async Task<IEnumerable<DataAccess.Models.Models.Person>> GetAsync()
        {
            var context = _contextFactory.Persons;

            await context.ToListAsync().ConfigureAwait(false);

            return context;
        }
    }
}
