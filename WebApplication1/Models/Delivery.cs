using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Delivery
    {
        public int ID { get; set; }
        public DateTime DateDelivery { get; set; }
        public int IDProduct { get; set; }
        public int IDOrderStatus { get; set; }
        public int IDPersons { get; set; }
        public int IDCountry { get; set; }
        public int IDCity { get; set; }
        public int IDWish { get; set; }
    }
}