using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using visual_studio.Models;

namespace visual_studio.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }
            
    }
}
