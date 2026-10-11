using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MVC02.Models.Classes;

namespace MVC02.Models.ConfigClass
{
    public class TeacherConfig : IEntityTypeConfiguration<Teacher>
    {
        public void Configure(EntityTypeBuilder<Teacher> T)
        {
            T.ToTable("Teacher");
            T.HasKey(s => s.Id);
            T.Property(s => s.Id)
                .UseIdentityColumn(10, 10);

            T.Property(s => s.Name)
                .HasMaxLength(50);

            T.HasOne(t => t.Department)
                .WithMany(d => d.Teachers)
                .HasForeignKey(t => t.DepartmentId)
                .OnDelete(DeleteBehavior.Restrict);
                

            T.HasOne(t=>t.Course)
                .WithMany(c=>c.Teachers)
                .HasForeignKey(t=>t.CourseId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
