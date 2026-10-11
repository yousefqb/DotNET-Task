namespace MVC02.Models.Classes
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public String MgrName { get; set; }
        public List<Student> Students { get; set; }
        public List<Course> Courses { get; set; }
        public List<Teacher> Teachers { get; set; }

    }
}
