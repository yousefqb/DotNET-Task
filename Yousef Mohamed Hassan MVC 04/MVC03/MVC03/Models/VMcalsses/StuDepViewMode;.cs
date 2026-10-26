using MVC03.Models.Classes;

namespace MVC03.Models.VMcalsses
{
    public class StuDepViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int DepartmentId { get; set; }

        public List<Department> Departments { get; set; }
    }
}
