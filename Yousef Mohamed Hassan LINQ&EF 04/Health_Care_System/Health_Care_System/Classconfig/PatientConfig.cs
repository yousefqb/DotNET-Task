using Health_Care_System.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Health_Care_System.Classconfig
{
    internal class PatientConfig : IEntityTypeConfiguration<Patient>
    {
        public void Configure(EntityTypeBuilder<Patient> P)
        {
            P.ToTable("Patients");
            P.HasKey(x => x.Id);
            P.Property(d => d.Id)
               .UseIdentityColumn(10, 10);
            
            P.Property(D => D.Name)
                .HasColumnType("nvarchar(max)")
                .IsRequired(true);
        }
    }
}
