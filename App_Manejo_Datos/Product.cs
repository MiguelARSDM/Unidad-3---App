using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Manejo_Datos
{
    public class Product
    {

        public int id { get; set; }
        public string name { get; set; }
        public decimal price { get; set; }
        public int stock { get; set; }
        public int category { get; set; }
        public string description { get; set; }
    }
}
