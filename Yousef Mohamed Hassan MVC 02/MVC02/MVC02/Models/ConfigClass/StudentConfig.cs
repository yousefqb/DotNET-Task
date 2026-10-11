using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MVC02.Models.Classes;

namespace MVC02.Models.ConfigClass
{
    public class StudentConfig : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> S)
        {
            S.ToTable("Students");
            S.HasKey(s => s.Id);
            S.Property(s=>s.Id)
                .UseIdentityColumn(10,10);

            S.Property(s=>s.Name)
                .HasMaxLength(50);

            S.HasOne(s => s.Department)
                .WithMany(D => D.Students)
                .HasForeignKey(s => s.DepartmentId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
