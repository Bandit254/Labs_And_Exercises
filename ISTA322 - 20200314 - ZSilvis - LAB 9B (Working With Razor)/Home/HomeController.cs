using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ISTA322___20200314___ZSilvis___LAB_9B__Working_With_Razor_.Models;

namespace ISTA322___20200314___ZSilvis___LAB_9B__Working_With_Razor_.Home
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            Product[] array =
            {
                new Product {Name = "Kayak", Price = 275M },
                new Product {Name = "Lifejacket", Price = 48.95M},
                new Product {Name = "Soccer Ball",Price = 19.50M},
                new Product {Name = "Corner Flag", Price = 34.95M}
            };


            /*
            Product myProduct = new Product
            {
                ProductID = 1,
                Name = "Kayak",
                Description = "A boat for one person",
                Category = "Watersports",
                Price = 275M
            };

            ViewBag.StockLevel = 2;
            */

            return View(array);
        }
    }
}
