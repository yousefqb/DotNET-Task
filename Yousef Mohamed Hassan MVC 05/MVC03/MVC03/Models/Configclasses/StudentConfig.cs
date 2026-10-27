using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MVC03.Models.Classes;

namespace MVC03.Models.Configclasses
{
    public class StudentConfig : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> S)
        {
            S.ToTable("Students");
            S.HasKey(s=>s.Id);
            S.Property(s=>s.Id)
                .UseIdentityColumn(1,1);
            S.Property(s=>s.Name)
                .HasMaxLength(50)
                .
            S.HasOne(s => s.Department)
                .WithMany(d => d.Students)
                .HasForeignKey(s => s.DepartmentId);

        }
    }
}
