namespace MVC02.Models.Classes
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
        public List<Teacher> Teachers { get; set; }
        public List<StuCrsRes> stuCrsRes { get; set; }
    }
}
