using Microsoft.AspNetCore.Mvc;
using MVC02.Models.ClassesBL;

namespace MVC02.Controllers
{
    public class StudentController : Controller
    {
        StudentBL studentBL = new StudentBL();

        // Student/ShowAll
        public IActionResult ShowAll()
        {
            return View("ShowAll",studentBL.GetAll());
        }

        // Student/ShowDetails?ID=.......
        public IActionResult ShowDetails(int ID)
        {
            return View("ShowDetails", studentBL.GetById(ID));
        }
    }
}
