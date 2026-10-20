using MVC03.Data.DbContexts;
using MVC03.Models.Classes;

namespace MVC03.Models.BLClasses
{
    public class StudentBL
    {
        DepiDbcontext context = new DepiDbcontext();
        public List<Student> Getall()
        {
            return context.Students.ToList();
        }

        public void AddDept(Department dept)
        {
            context.Departments.Add(dept);
            context.SaveChanges();
        }
    }
}
