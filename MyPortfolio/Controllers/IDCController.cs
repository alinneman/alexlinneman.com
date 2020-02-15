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
using MyPortfolio.Managers;
using Newtonsoft.Json;

namespace MyPortfolio.Controllers
{
    public class IDCController : Controller
    {
        private readonly ILogger<IDCController> _logger;

        public IDCController(ILogger<IDCController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Index(string city, string latitude, string longitude)
        {
            ViewBag.city = city;
            ViewBag.latitude = latitude;
            ViewBag.longitude = longitude;
            if (String.IsNullOrWhiteSpace(city) && String.IsNullOrWhiteSpace(latitude) && String.IsNullOrWhiteSpace(longitude))
            {
                return RedirectToAction("Error", "IDC", new { message = "Somehow I lost your search location along the way. Please go back and try again." });
            }
            else
            {
                return View();
            }            
        }
        public IActionResult Error(string message, string city)
        {
            ViewBag.message = message;
            ViewBag.city = city;
            return View();
        }
        public async Task<IActionResult> Details(string city, string latitude, string longitude, string radius, string price, string rating, string openNow, string cats)
        {
            IDCManager manager = new IDCManager();
            Business business = await manager.GetRandomBusiness(city, latitude, longitude, radius, price, rating, openNow, cats);
            if (business.hasErrors)
            {
                return RedirectToAction("Error", "IDC", new { message = "The filters applied returned no results. Please go back and try to broaden your filters.", city = city});
            }
            else
            {
                YelpBusiness yelpBusiness = await manager.GetBusinessDetails(business.id);
                YelpReviews yelpReviews = await manager.GetYelpReviews(business.id);
                int dayOfWeek = ((int)DateTime.Now.DayOfWeek == 0) ? 7 : (int)DateTime.Now.DayOfWeek;
                string hoursToday = "";
                if(yelpBusiness.Hours != null)
                {
                    foreach (var day in yelpBusiness.Hours.FirstOrDefault().Open)
                    {
                        if (day.Day == (dayOfWeek - 1))
                        {

                            hoursToday = (String.IsNullOrWhiteSpace(hoursToday)) ? manager.ConvertToHoursToday(day.Start, day.End) : hoursToday + ", " + manager.ConvertToHoursToday(day.Start, day.End);
                        }
                    }
                }
                else
                {
                    hoursToday = "Not yet released for this business.";
                }
                yelpBusiness.Price = manager.ConvertPrice(yelpBusiness.Price);
                YelpCompleteDetails details = new YelpCompleteDetails
                {
                    YelpBusiness = yelpBusiness,
                    YelpReviews = yelpReviews,
                    HoursToday = hoursToday,
                    ReviewImage = manager.YelpStarSelector(yelpBusiness.Rating)
                };

                return View(details);
            }
            
        }
    }
}
