using Microsoft.EntityFrameworkCore;
using MVC03.Data.DbContexts;
using MVC03.Models.Classes;

namespace MVC03.Models.BLClasses
{
    public class DepartmentBL
    {
        DepiDbcontext context = new DepiDbcontext();
        public List<Department> Getall()
        {
            return context.Departments.Include(d=>d.Students).ToList();
        }
        public Department GetbyId(int id) 
        {
            return context.Departments.FirstOrDefault(d=>d.Id==id);
        }
        public void AddDept(Department dept) 
        {
            context.Departments.Add(dept);
            context.SaveChanges();
        }
    }
}
