using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Order
    {
        public int ID { get; set; }
        public DateTime DateTime { get; set; }
        public string Product { get; set; }
        public string OrderStatus { get; set; }
        public string ProductInfo { get; set; }
        public int Weight { get; set; }
        public int Persons { get; set; }
        public int Country { get; set; }
        public int City { get; set; }
        public int Summa { get; set; }
        public string Category { get; set; }
    }
}