using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Wish
    {
        public int ID { get; set; }
        public int IDCat { get; set; }
        public int MaxWeight { get; set; }
        public string TextWish { get; set; }
    }
}