using DbYonetimSistemi.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DbYonetimSistemi.Controllers
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

        public IActionResult Mutlu()
        {

            return View();
        }
        public IActionResult Onur()
        {

            return View();
        }
    }
}