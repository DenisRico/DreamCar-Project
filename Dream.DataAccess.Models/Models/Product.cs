using System;
using System.Collections.Generic;
using System.Text;

namespace Dream.DataAccess.Models.Models
{
    public class Product
    {
        public int Id { get; set; }   //id
        public string Name { get; set; }    // name 
        public string Company { get; set; } // company
        public int Price { get; set; }  // price
    }
}
