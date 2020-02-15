using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MyPortfolio.API;
using MyPortfolio.Models;
using Newtonsoft.Json;

namespace MyPortfolio.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Resume()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }
        public IActionResult IDCApp()
        {
            //var x = new YelpApi();
            //Task<YelpSearchResult> y = x.GetYelpSearchResultsAsync(2000, 40.8327791, -96.6864045, "$$$", "pizza,seafood,newamerican", "hot_and_new");
            return View();
        }
        [HttpPost]
        public IActionResult IDCApp(string city, string latitude, string longitude)
        {

            return RedirectToAction("Index", "IDC", new { city = city, latitude = latitude, longitude = longitude });
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
