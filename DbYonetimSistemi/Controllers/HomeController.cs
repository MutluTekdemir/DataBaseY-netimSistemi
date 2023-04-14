using DbYonetimSistemi.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DbYonetimSistemi.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        string GitDeneme;
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
         
            return View();
        }

   
    }
}