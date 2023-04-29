using Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DbYonetimSistemi.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        
        public LoginController()
        {
           
        }
        public IActionResult Index()
        {
            return View();
        }







    }
}
