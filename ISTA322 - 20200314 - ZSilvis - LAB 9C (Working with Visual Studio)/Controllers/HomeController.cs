using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ISTA322___20200314___ZSilvis___LAB_9C__Working_with_Visual_Studio_.Models;

namespace ISTA322___20200314___ZSilvis___LAB_9C__Working_with_Visual_Studio_.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index() => View(SimpleRepository.SharedRepository.Products.Where(p=>p?.Price<50));
    }
}
