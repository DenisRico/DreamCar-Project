using System;
using System.Collections.Generic;
using System.Text;

namespace Dream.DataAccess.Models.Models
{
    public class Car
    {
        public int Id { get; set; }   //id
        public string Name { get; set; }    // name 
        public int Year { get; set; } // year
        public string Condition { get; set; }  // condition 
        public string FuelType { get; set; }  // Fuel type
        public string Color { get; set; }  // color
        public int Price { get; set; }  // price
        public string Description { get; set; }  // definition 
        public string Image { get; set; }  // image
    }
}
