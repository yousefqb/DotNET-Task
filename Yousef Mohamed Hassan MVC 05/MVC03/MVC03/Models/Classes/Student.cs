using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace MVC03.Models.Classes
{
    public class Student
    {
        [HiddenInput(DisplayValue = false)]
        public int Id { get; set; }
        [Display(Name = "Full Name")]
        [Required(ErrorMessage ="add a name")]
        [MaxLength(30, ErrorMessage ="less than 30")]
        [MinLength(3, ErrorMessage = "more than 3")]
        [RegularExpression(@"^[a-zA-Z\s]+$",, ErrorMessage = "musi in this exceprision[a-z,A-Z,spaces]")]
        public string Name { get; set; }


        [Required(ErrorMessage = "add a salary")]
        [Range(7000, 20000,ErrorMessage ="must be in 7000 to 20000")]
        public int Salary { get; set; }
        [Display]
        [Required(ErrorMessage = "add a department")]
        [Range(1, int.MaxValue)]
        public int DepartmentId { get; set; }
        public Department? Department { get; set; }
    }
}
