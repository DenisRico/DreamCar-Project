﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Dream.DataAccess.Context;
using Dream.DataAccess.Models.Models;
using Dream.Interfaces.Services;
using Microsoft.AspNetCore.Http;
//using TestAngular5.Models;


namespace TestAngular5.Controllers
{
    [ApiController]
    [Route("api/cars")]
    public class CarController : Controller
    {
        //service
        ICarService _carService;
        //DataBase context
        ApplicationContext db;
        public CarController(ApplicationContext context, ICarService carService)
        {
            db = context;
            _carService = carService;

        }

        ///// <summary>
        ///// Получаем список Car
        ///// </summary>
        ///// <returns></returns>
        [HttpGet]
        public async Task<ActionResult> Get()
        {
            try
            {
                return Ok(await _carService.GetAsync());
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e);
            }
        }

       

        /// <summary>
        /// Получаем объект car по id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public Car Get(int id)
        {
            Car car = db.Cars.FirstOrDefault(x => x.Id == id);
            return car;
        }

        [HttpPost]
        public async Task<IActionResult> Post(Car car)
        {
            try
            {
                if (car == null) return BadRequest("car is required");

                await _carService.AddAsync(car);

                return Ok();
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e);
            }
        }

        ///// <summary>
        ///// Добавляем объект car
        ///// </summary>
        ///// <param name="car"></param>
        ///// <returns></returns>
        //[HttpPost]
        //public IActionResult Post(Car car)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.Cars.Add(car);
        //        db.SaveChanges();
        //        return Ok(car);
        //    }
        //    return BadRequest(ModelState);
        //}


        /// <summary>
        /// Обновление Car
        /// </summary>
        /// <param name="car"></param>
        /// <returns></returns>
        [HttpPut]
        public async Task<IActionResult> Put(Car car)
        {
            try
            {
                if(car==null) return BadRequest("car is required");

                await _carService.UpdateAsync(car);

                return Ok();
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e);
            }
        }


        ///// <summary>
        ///// Обновление Car
        ///// </summary>
        ///// <param name="car"></param>
        ///// <returns></returns>
        //[HttpPut]
        //public IActionResult Put(Car car)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.Update(car);
        //        db.SaveChanges();
        //        return Ok(car);
        //    }
        //    return BadRequest(ModelState);
        //}


        /// <summary>
        /// Удаление Car
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                await _carService.DeleteAsync(id);

                return Ok();
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e);
            }
        }

        ///// <summary>
        ///// Удаление Car
        ///// </summary>
        ///// <param name="id"></param>
        ///// <returns></returns>
        //[HttpDelete("{id}")]
        //public IActionResult Delete(int id)
        //{
        //    Car car = db.Cars.FirstOrDefault(x => x.Id == id);
        //    if (car != null)
        //    {
        //        db.Cars.Remove(car);
        //        db.SaveChanges();
        //    }
        //    return Ok(car);
        //}

    }
}