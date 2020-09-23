using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AdamCore.Models;

namespace AdamCore.Controllers
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

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpGet]
        public int MyAction()
        {

            return 666;
        }

        public String[] ImageUploadGet()
        {

            string[] images = { "images/construction_lights.jpg", "images/maddi_web2.jpg", "images/tuccs.jpg" };

            //string x = "images/cool-bridge.jpg";
            //string y = "images/oakland_street.jpg";

            return images;
        }



    }
}
