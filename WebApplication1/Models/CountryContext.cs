using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace WebApplication1.Models
{
    public class CountryContext : DbContext
    {
        public DbSet<Country> Countrys { get; set; }
        public DbSet<Purchase> Purchases { get; set; }
        public DbSet<Delivery> Deliverys { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Category> Categories { get; set; }
        //public DbSet<Order> Orders { get; set; }

        public System.Data.Entity.DbSet<WebApplication1.Models.Order> Orders { get; set; }
    }
}