namespace MVC02.Models.Classes
{
    public class Teacher
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public String Address { get; set; }
        public int Degree { get; set; }
        public int MinDegree { get; set; }
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
        public int CourseId { get; set; }
        public Course Course { get; set; }

    }
}
