using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MVC02.Models.Classes;

namespace MVC02.Models.ConfigClass
{
    public class DepartmentConfig : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> D)
        {
            D.ToTable("Departments");
            D.HasKey(s => s.Id);
            D.Property(s => s.Id)
                .UseIdentityColumn(10, 10);

            D.Property(s => s.Name)
                .HasMaxLength(50);
        }
    }
}
