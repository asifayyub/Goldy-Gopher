using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVC_Application.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Application.Controllers
{
    public class HomeController : Controller
    {
        

        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Index(HomeModel home)
        {
            int lower = home.LowerBound;
            int upper = home.UpperBound;

            ViewBag.Lower = lower;
            ViewBag.Upper = upper;

            return View();

        }

       
    }
}
