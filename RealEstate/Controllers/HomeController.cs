using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RealEstate.Models;
using RealEstate.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace RealEstate.Controllers
{
    public class HomeController : Controller
    {

        private ItownCenter _townCenter;

       
        public HomeController(ItownCenter itownCenter)
        {
            _townCenter = itownCenter;
        }

        public IActionResult Index() 
        {
            var center = _townCenter.GetTowns();
            

            return View(center);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
