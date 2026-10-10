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
    internal class AppointmentConfig : IEntityTypeConfiguration<Appointment>
    {
        public void Configure(EntityTypeBuilder<Appointment> A)
        {
            A.ToTable("Appointments");

            A.HasKey(a => new { a.DoctorId, a.PatientId });

            A.HasOne(a => a.Doctor)
                .WithMany(d => d.DoctorPatients)
                .HasForeignKey(a => a.DoctorId)
                .OnDelete(DeleteBehavior.Restrict);

            A.HasOne(a=>a.Patient)
                .WithMany(b=>b.PatientDoctors)
                .HasForeignKey(a=>a.PatientId)
                .OnDelete(DeleteBehavior.Restrict);
            
        }

    }
}
