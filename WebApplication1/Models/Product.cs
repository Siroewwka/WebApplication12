using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Product
    {
        public int ID { get; set; }
        public string Name{ get; set; }
        public int IDCat { get; set; }
        public string Info { get; set; }
        public int Weight { get; set; }
    }
}