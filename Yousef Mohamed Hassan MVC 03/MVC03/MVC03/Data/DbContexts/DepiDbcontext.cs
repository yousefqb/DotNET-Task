using Microsoft.EntityFrameworkCore;
using MVC03.Models.Classes;
using MVC03.Models.Configclasses;

namespace MVC03.Data.DbContexts
{
    public class DepiDbcontext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=Depi;Integrated Security=True;Encrypt=False;Trust Server Certificate=True");
        }

        public DbSet<Department> Departments { get; set; }
        public DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new DepartmentConfig());
            modelBuilder.ApplyConfiguration(new StudentConfig());
        }
    }
}
