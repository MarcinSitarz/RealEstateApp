using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using RealEstate.Models;
using RealEstate.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
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
            var webClient = new WebClient();


            var path = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).FullName, "RealEstate\\Json\\WeatherForecast.json");
            var json = webClient.DownloadString(path);

           var test = JsonConvert.DeserializeObject<Deserials>(json);

            return View(test);
        }
        public IActionResult AddTowns(Town tylda)
        {
            _townCenter.AddTown(tylda);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteTowns()
        {
            
            _townCenter.DeleteTown();
            return RedirectToAction("Index");
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
