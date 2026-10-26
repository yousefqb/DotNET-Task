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

        public Student GetbyId(int id)
        {
            return context.Students.FirstOrDefault(d => d.Id == id);
        }
        public void AddStu(Student student)
        {
            context.Students.Add(student);
            context.SaveChanges();
        }
        public void SaveInDB()
        {
            context.SaveChanges();
        }

        public void Delete(Student student)
        {
            context.Students.Remove(student);
            context.SaveChanges();
        }

    }
}
