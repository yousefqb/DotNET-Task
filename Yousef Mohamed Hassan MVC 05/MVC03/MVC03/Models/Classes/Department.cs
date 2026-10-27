using System.ComponentModel.DataAnnotations;

namespace MVC03.Models.Classes
{
    public class Department
    {
        public int Id { get; set; }
        [Display(Name = "Full Name")]
        [Required(ErrorMessage = "add a name")]
        [MaxLength(30, ErrorMessage = "less than 30")]
        [MinLength(3, ErrorMessage = "more than 3")]
        [RegularExpression(@"^[a-zA-Z\s]+$",, ErrorMessage = "musi in this exceprision[a-z,A-Z,spaces]")]
        public string Name { get; set; }
        public List<Student> Students { get; set; }
    }
}
