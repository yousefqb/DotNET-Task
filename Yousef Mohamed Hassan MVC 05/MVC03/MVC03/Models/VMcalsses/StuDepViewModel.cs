using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MVC03.Models.Classes;
using System.ComponentModel.DataAnnotations;

namespace MVC03.Models.VMcalsses
{
    public class StuDepViewModel
    {
        
        [HiddenInput(DisplayValue =false)]
        public int Id { get; set; }

        public string Name { get; set; }
        public int Salary { get; set; }

        public int DepartmentId { get; set; }

        [Display(Name = "Department Name")]
        public SelectList Departments { get; set; }
    }
}
