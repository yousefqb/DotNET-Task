using Microsoft.AspNetCore.Mvc;
using MVC03.Models.BLClasses;
using MVC03.Models.Classes;

using MVC03.Models.VMcalsses;

namespace MVC03.Controllers
{
    public class StudentController : Controller
    {
        StudentBL studentBL = new StudentBL();

        DepartmentBL departmentBL = new DepartmentBL();
        [HttpGet]
        public IActionResult Index()
        {
            return View("Index",studentBL.Getall());
        }

        [HttpGet]
        public IActionResult byid(int id)
        {
            return View("byid", studentBL.GetbyId(id));
        }

        [HttpGet]
        public IActionResult Add() 
        {
            return View("Add");
        }

        [HttpPost]
        public IActionResult SaveAdd(Student student) 
        {
            if (student.Name != null&&student.DepartmentId !=0)
            {
                studentBL.AddStu(student);
                return RedirectToAction(nameof(Index));
            }
            return View("Add", student);
        }

        [HttpGet]
        public IActionResult Edit(int id) 
        {

            Student stu = studentBL.GetbyId(id);
            List<Department> Deplist = departmentBL.Getall();

            StuDepViewModel SDVM = new StuDepViewModel()
            {
                Id=stu.Id,
                Name=stu.Name,
                DepartmentId=stu.DepartmentId,
                Departments=Deplist
            };
            

            return View("Edit" , SDVM);
        }

        [HttpPost]
        public IActionResult SaveEdit(Student student,int Id) 
        {
            if(student.Name != null)
            {
            Student oldstudent = studentBL.GetbyId(Id);
            
                oldstudent.Name = student.Name;
                oldstudent.DepartmentId = student.DepartmentId;
                studentBL.SaveInDB();
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View("Edit", student);
            }
        }
        public IActionResult Delete(int id) 
        {
            return View("Delete",studentBL.GetbyId(id));
        }

        public IActionResult ConfirmDelete(int id) 
        {
            Student del =studentBL.GetbyId(id);
            if (del != null) 
            {
                studentBL.Delete(del);
            return RedirectToAction(nameof(Index));
            }
            return NotFound();
        }
    }
}
