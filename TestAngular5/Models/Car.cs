using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestAngular5.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string Name { get; set; }    // название 
        public int Year { get; set; } // год
        public string Condition { get; set; }  // Состояение 
        public string FuelType { get; set; }  // Вид топлива
        public string Color { get; set; }  // цвет
        public int Price { get; set; }  // цена
        public string Description { get; set; }  // описание 
        public string Image { get; set; }  // картинка
    }
}
