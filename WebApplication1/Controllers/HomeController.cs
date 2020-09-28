using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {

       CountryContext CountryContext = new CountryContext();



        //public ActionResult OrderView()
        public ActionResult Index()
        {
            IEnumerable<Country> Countrys = CountryContext.Countrys;
            IEnumerable<Category> Categories = CountryContext.Categories;
            IEnumerable<City> Cities = CountryContext.Cities;

            ViewBag.Countrys = Countrys;
            ViewBag.Categories = Categories;
            ViewBag.Cities = Cities;

            return View();

        }
        [HttpPost]
        public string Index(Order purchase)
        {
            purchase.DateTime = GetTodayTime();

            CountryContext.Orders.Add(purchase);
            CountryContext.SaveChanges();

            return $"Уважаемый, заказчик, после проверки введенных данных заявку будет опубликована";
        }

        [HttpGet]
       public ActionResult Buy(int id)
       {
            ViewBag.Id = id;

            return View();
        }
        [HttpPost]
        public string Buy(Purchase purchase)
        {
            purchase.DateTime = GetTodayTime();

            CountryContext.Purchases.Add(purchase);
            CountryContext.SaveChanges();

            return $"Уважаемый, заказчик, после проверки введенных данных заявку будет опубликована";
        }
        private DateTime GetTodayTime()
        {
            return DateTime.Now;
        }

        [HttpGet]
        public ActionResult SomeMethod()
        {
            ViewData["Date"] = DateTime.Now;
            return View("/Views/Home/MyView.cshtml");
        }
        [HttpGet]
        public ActionResult SomeView()
        {
            return View();
        }
    }
}