using KendoUiGrid.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KendoUiGrid.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<Car> defaultCars = new List<Car> {
                new Car{ Color="Red", Model="Audi", Price=2000, Year= 2012 },
                new Car{ Color="Black", Model="Audi", Price=5000, Year= 2015 },
                new Car{ Color="Dark Blue", Model="BMW", Price=2300, Year= 2012 },
                new Car{ Color="White", Model="Opel", Price=10000, Year= 2013 },
                new Car{ Color="Yellow", Model="Audi", Price=4500, Year= 2014 },
                new Car{ Color="Green", Model="Mersedes", Price=23000, Year= 2018 },
                new Car{ Color="Red", Model="Audi", Price=1200, Year= 2006 }


            };
            return View(defaultCars);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}