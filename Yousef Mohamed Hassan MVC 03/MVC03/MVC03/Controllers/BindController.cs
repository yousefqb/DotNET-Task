using Microsoft.AspNetCore.Mvc;

namespace MVC03.Controllers
{
    public class BindController : Controller
    {
        public IActionResult add(string name)
        {
            return Content("ok");
        }
    }
}
