using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestAngular5.Models
{
    public class Song
    {
        public int Id { get; set; }
        public string Name { get; set; }    // название 
        public string Company { get; set; }
        public int Price { get; set; }  // цена
    }
}
