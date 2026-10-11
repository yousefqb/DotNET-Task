using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MVC02.Models.Classes;

namespace MVC02.Models.ConfigClass
{
    public class CourseConfig : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> C)
        {
            C.ToTable("Courses");
            C.HasKey(s => s.Id);
            C.Property(s => s.Id)
                .UseIdentityColumn(10, 10);
            
            C.Property(s => s.Name)
                .HasMaxLength(50);

            C.HasOne(c => c.Department)
                .WithMany(d => d.Courses)
                .HasForeignKey(c=>c.DepartmentId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
