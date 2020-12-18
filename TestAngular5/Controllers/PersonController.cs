using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Dream.DataAccess.Context;
using Dream.DataAccess.Models.Models;
using Dream.Interfaces.Services;
using Microsoft.AspNetCore.Http;


namespace TestAngular5.Controllers
{
    [ApiController]
    [Route("api/persons")]
    public class PersonController:Controller
    {
        //service
        IPersonService _personService;

        //DataBase context
        DatabaseContext db;
        public PersonController(DatabaseContext context, IPersonService personService)
        {
            db = context;
            _personService = personService;

        }

        ///// <summary>
        ///// Получаем список Person
        ///// </summary>
        ///// <returns></returns>
        [HttpGet]
        public async Task<ActionResult> Get()
        {
            try
            {
                return Ok(await _personService.GetAsync());
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e);
            }
        }







    }
}
