using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using thehaguetech_community_portal.Models;

namespace thehaguetech_community_portal.Controllers
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

        public IActionResult Profile()
        {
            return View();
        }

        public IActionResult Calendar()
        {
            return View();
        }
        public IActionResult Companies()
        {
            return View();
        }

        
        public IActionResult Members()
        {

            var p =   Apicontroller.getMember("5dd7969300936900dacca60b");
            
            return View();
        }
        public IActionResult Settings()
        {
            return View();
        }
        public IActionResult Support()
        {
            return View();
        }
        public IActionResult Event()
        {
            return View();
        }
        public IActionResult RoomBooking()
        {
            return View();
        }
        public IActionResult Notification()
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
