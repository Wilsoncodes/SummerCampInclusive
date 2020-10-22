using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Session;
using Microsoft.Extensions.Logging;
using Summer_Camp.Models;

namespace Summer_Camp.Controllers
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
            ViewingBag();
            return View();
        }

        public IActionResult Help()
        {
            ViewingBag();
            return View();
        }

        public IActionResult Admin()
        {
            ViewingBag();
            return View();
        }

        public IActionResult Login(string role)
        {
            if(role != null)
            {
                HttpContext.Session.SetString("Authorized", "true");

                if (role == "teacher")
                {
                    HttpContext.Session.SetString("IsTeacher", "true");
                }
                else
                {
                    HttpContext.Session.SetString("IsTeacher", "false");
                }
                if (role == "admin")
                {
                    HttpContext.Session.SetString("IsAdmin", "true");
                }
                else
                {
                    HttpContext.Session.SetString("IsAdmin", "false");
                }

            }

            ViewingBag();

            return View();
        }

        public IActionResult Profile()
        {
            ViewingBag();
            return View();
        }

        public IActionResult Student()
        {
            ViewingBag();
            return View();
        }
        public IActionResult Teacher()
        {
            ViewingBag();
            return View();
        }

        public IActionResult Volunteer()
        {
            ViewingBag();
            return View();
        }

        public IActionResult Privacy()
        {
            ViewingBag();
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public void ViewingBag()
        {
            try
            {
                ViewBag.IsAdmin = HttpContext.Session.GetString("IsAdmin");
                ViewBag.IsTeacher = HttpContext.Session.GetString("IsTeacher");
                ViewBag.Authorized = HttpContext.Session.GetString("Authorized");
            }
            catch
            {

            }
        }
    }
}
