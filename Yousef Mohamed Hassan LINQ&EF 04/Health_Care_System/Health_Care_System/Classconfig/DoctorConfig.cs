using Health_Care_System.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Health_Care_System.Classconfig
{
    internal class DoctorConfig : IEntityTypeConfiguration<Doctor>
    {
        public void Configure(EntityTypeBuilder<Doctor> D)
        {
            D.ToTable("Doctors");

            D.HasKey(x => x.Id);
            D.Property(d=>d.Id)
                .UseIdentityColumn(10,10);

            D.Property(D => D.Name)
                .HasColumnType("nvarchar(max)")
                .IsRequired(true);
        }
    }
}
