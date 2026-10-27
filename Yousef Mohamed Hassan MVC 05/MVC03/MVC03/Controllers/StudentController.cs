using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
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
            ViewData["DeptList"]=new SelectList(departmentBL.Getall(),"Id","Name");
            return View("Add");
        }

        [HttpPost]
        public IActionResult SaveAdd(Student student) 
        {
            if (ModelState.IsValid)
            {
                studentBL.AddStu(student);
                return RedirectToAction(nameof(Index));
            }
            ViewData["DeptList"] = new SelectList(departmentBL.Getall(), "Id", "Name");
            return View("Add", student);
        }

        [HttpGet]
        public IActionResult Edit(int id) 
        {

            Student stu = studentBL.GetbyId(id);

            StuDepViewModel SDVM = new StuDepViewModel()
            {
                Id=stu.Id,
                Name=stu.Name,
                Salary=stu.Salary,
                DepartmentId=stu.DepartmentId,
                Departments= new SelectList(departmentBL.Getall(), "Id", "Name")
            };
            
            return View("Edit" , SDVM);
        }

        
        public IActionResult SaveEdit(Student student,int Id) 
        {
            if(ModelState.IsValid)
            {
            Student oldstudent = studentBL.GetbyId(Id);
            
                oldstudent.Name = student.Name;
                oldstudent.Salary = student.Salary;
                oldstudent.DepartmentId = student.DepartmentId;
                studentBL.SaveInDB();
                return RedirectToAction(nameof(Index));
            }
            else
            {
                StuDepViewModel SDVM = new StuDepViewModel()
                {
                    Id = student.Id,
                    Name = student.Name,
                    Salary = student.Salary,
                    DepartmentId = student.DepartmentId,
                    Departments = new SelectList(departmentBL.Getall(), "Id", "Name")
                };

                return View("Edit", SDVM);
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
