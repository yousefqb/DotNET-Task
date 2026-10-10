using Microsoft.AspNetCore.Mvc;
using MVC00.Models;
using System.Diagnostics;

namespace MVC00.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult showmsg(int Id)    
        {
            if (Id == 0)
                return View("View1");
            else
                return Content("no action");
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
    }
}
