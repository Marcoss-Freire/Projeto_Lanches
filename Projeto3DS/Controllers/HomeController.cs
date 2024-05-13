using Microsoft.AspNetCore.Mvc;
using Projeto3DS.Models;
using System.Diagnostics;

namespace Projeto3DS.Controllers
{
    public class HomeController : Controller
    { 
        public IActionResult Index()
        {
            return View();
        }
   
    }
}
