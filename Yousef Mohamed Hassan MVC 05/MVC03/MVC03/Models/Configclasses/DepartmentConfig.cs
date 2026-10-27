using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MVC03.Models.Classes;

namespace MVC03.Models.Configclasses
{
    public class DepartmentConfig : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> D)
        {
            D.ToTable("Departments");
            D.HasKey(d=>d.Id);
            D.Property(d => d.Id).UseIdentityColumn(1,1);
            D.Property(d => d.Name)
                .HasMaxLength(50);
        }
    }
}
