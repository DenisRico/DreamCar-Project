using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Dream.DataAccess.Context;
using Dream.DataAccess.Models.Models;
//using TestAngular5.Models;

namespace TestAngular5.Controllers
{
    [ApiController]
    [Route("api/songs")]
    public class SongController : Controller
    {
        ApplicationContext db;
        public SongController(ApplicationContext context)
        {
            db = context;
            //if (!db.Songs.Any())
            //{
            //    db.Songs.Add(new Song { Name = "Leftover Crack", Company = "Crack", Price = 79900 });
            //    db.Songs.Add(new Song { Name = "Catch 22", Company = "Cat", Price = 49900 });
            //    db.Songs.Add(new Song { Name = "Fred", Company = "Freddy", Price = 52900 });
            //    db.SaveChanges();
            //}
        }
        [HttpGet]
        public IEnumerable<Song> Get()
        {

            return db.Songs.ToList();
        }

        [HttpGet("{id}")]
        public Song Get(int id)
        {
            Song song = db.Songs.FirstOrDefault(x => x.Id == id);
            return song;
        }

        [HttpPost]
        public IActionResult Post(Song song)
        {
            if (ModelState.IsValid)
            {
                db.Songs.Add(song);
                db.SaveChanges();
                return Ok(song);
            }
            return BadRequest(ModelState);
        }

        [HttpPut]
        public IActionResult Put(Song song)
        {
            if (ModelState.IsValid)
            {
                db.Update(song);
                db.SaveChanges();
                return Ok(song);
            }
            return BadRequest(ModelState);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            Song song = db.Songs.FirstOrDefault(x => x.Id == id);
            if (song != null)
            {
                db.Songs.Remove(song);
                db.SaveChanges();
            }
            return Ok(song);
        }
    }
}
