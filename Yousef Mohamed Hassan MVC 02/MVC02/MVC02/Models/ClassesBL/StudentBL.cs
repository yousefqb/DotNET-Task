using MVC02.Data.DbContexts;
using MVC02.Models.Classes;

namespace MVC02.Models.ClassesBL
{
    public class StudentBL
    {
        SchoolDbcontext context=new SchoolDbcontext();
        public List<Student> GetAll()
        {
            return context.Students.ToList();
        }
        public Student GetById(int Id)
        {
            return context.Students.FirstOrDefault(s => s.Id == Id);
        }
    } 
}
