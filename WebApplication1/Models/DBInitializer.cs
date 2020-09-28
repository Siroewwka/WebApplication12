using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace WebApplication1.Models
{
    public class DBInitializer : DropCreateDatabaseAlways<CountryContext>
    {
        protected override void Seed(CountryContext context)
        {
            context.Countrys.Add(new Country() { Name = "ОАЭ" });
            context.Countrys.Add(new Country() { Name = "Ирландия" });
            context.Countrys.Add(new Country() { Name = "Египет" });
            context.Countrys.Add(new Country() { Name = "Польша" });
            context.Countrys.Add(new Country() { Name = "Монголия" });
            context.Countrys.Add(new Country() { Name = "Тайланд" });
            context.Countrys.Add(new Country() { Name = "Вьетнам" });

            //context.Products.Add(new Product() { Name = "Манго"});
            //context.Products.Add(new Product() { Name = "Футболка"});
            //context.Products.Add(new Product() { Name = "Виски"});
            //context.Products.Add(new Product() { Name = "Магнит"});
            //context.Products.Add(new Product() { Name = "Ром"});
            //context.Products.Add(new Product() { Name = "Маракуйя"});

            context.Cities.Add(new City() { Name = "Пермь" });
            context.Cities.Add(new City() { Name = "Москва" });
            context.Cities.Add(new City() { Name = "Казань" });
            context.Cities.Add(new City() { Name = "Санкт-Петербург" });

            context.Categories.Add(new Category() { Name = "Фрукты" });
            context.Categories.Add(new Category() { Name = "Одежда" });
            context.Categories.Add(new Category() { Name = "Сувениры" });
            context.Categories.Add(new Category() { Name = "Алкоголь" });

            base.Seed(context);
        }

    }
}