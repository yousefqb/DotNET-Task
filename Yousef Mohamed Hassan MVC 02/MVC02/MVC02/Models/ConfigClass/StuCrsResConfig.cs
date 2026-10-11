using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MVC02.Models.Classes;

namespace MVC02.Models.ConfigClass
{
    public class StuCrsResConfig : IEntityTypeConfiguration<StuCrsRes>
    {
        public void Configure(EntityTypeBuilder<StuCrsRes> SR)
        {
            SR.ToTable("StuCrsRes");

            SR.HasKey(sr => new { sr.StudentId, sr.CourseId });

            SR.HasOne(sr => sr.Student)
               .WithMany(s => s.StuCrsRes)
               .HasForeignKey(sr => sr.StudentId)
               .OnDelete(DeleteBehavior.Restrict);

            SR.HasOne(sr => sr.Course)
                .WithMany(c => c.stuCrsRes)
                .HasForeignKey(sr => sr.CourseId)
                .OnDelete(DeleteBehavior.Restrict);

        }
    }
}