using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using hello_world.Models;
using Newtonsoft.Json;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Routing;

namespace hello_world.Controllers
{
    
    [Route("[controller]")]
    public class HomeController : Controller
    {
        private ILogger<HomeController> _logger;
        private LinkGenerator _linkGenerator;

        public HomeController(
            ILogger<HomeController> logger,
            LinkGenerator linkGenerator
        )
        {
            _logger = logger;
            _linkGenerator = linkGenerator;
        }

        [HttpGet("")]
        [HttpGet("/")]
        [HttpGet("[action]")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("[action]")]
        public IActionResult Link()
        {
            var link = _linkGenerator.GetPathByAction("Privacy", "Home");
            var url = Url.RouteUrl("Products_List", new {}, Request.Scheme);
            return Content(url);
        }

        private static User _User = new User {
                Username = "Todd",
                Fullname = "Todd Spatafore",
                Password = "My strong password."
            };

        [HttpGet("[action]", Name = "Products_List")]
        public IActionResult Privacy()
        {
            string json = JsonConvert.SerializeObject(_User, Formatting.Indented);
            _logger.LogInformation(json);
            return View(_User);
        }

        [HttpPost("[action]")]
        public IActionResult Privacy(User user)
        {
            if (ModelState.IsValid)
            {
                _User.Fullname = user.Fullname;
                _User.Username = user.Username;
                _User.Password = user.Password;
                return RedirectToAction("Privacy");
            }
            else
            {
                return View(user);
            }
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
