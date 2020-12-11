using System;
using System.Collections.Generic;
using System.Text;

namespace Dream.DataAccess.Models.Models
{
    public class Song
    {
        public int Id { get; set; }
        public string Name { get; set; }    // name 
        public string Company { get; set; } //company
        public int Price { get; set; }  // price
    }
}
