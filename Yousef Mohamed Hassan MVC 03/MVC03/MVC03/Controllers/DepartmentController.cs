using Microsoft.AspNetCore.Mvc;
using MVC03.Models.BLClasses;
using MVC03.Models.Classes;
using MVC03.Models.VMcalsses;

namespace MVC03.Controllers
{
    public class DepartmentController : Controller
    {
        DepartmentBL departmentBL = new DepartmentBL();

        // Department/Index
        [HttpGet]
        public IActionResult Index()
        {
            return View("index", departmentBL.Getall());
        }

        // Department/byid?id=1
        [HttpGet]
        public IActionResult byid(int id)
        {
            return View("byid", departmentBL.GetbyId(id));
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View("Add");
        }

        [HttpPost]
        public IActionResult SaveAdd(Department department)
        {
            if (department.Name != null)
            {
                departmentBL.AddDept(department);
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View("Add", department);
            }
        }
        //  /Department/deptwithstudent
        public IActionResult deptwithstudent()
        {
            List<Department> departments = departmentBL.Getall();
            List<deptwithstudentVM> dwsList = new List<deptwithstudentVM>();


            foreach (Department item in departments)
            {
                deptwithstudentVM dws = new deptwithstudentVM();
                dws.deptname = item.Name;
                if (item.Students != null)
                {
                    foreach (Student it in item.Students)
                    {
                        dws.stunames.Add(it.Name);
                    }
                }
                dwsList.Add(dws);
            }
            return View("deptwithstudent", dwsList);
        }
        
    
    }
}
