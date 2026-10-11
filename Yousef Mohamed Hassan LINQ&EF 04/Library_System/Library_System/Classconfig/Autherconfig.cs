using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library_System.Models;

namespace Library_System.Classconfig
{
    internal class Autherconfig : IEntityTypeConfiguration<Author>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Author> A)
        {
            A.ToTable("Authors");

            A.HasKey(b => b.Id);
            A.Property(b => b.Id)
                .UseIdentityColumn(1, 1);

            A.Property(b => b.Name)
                    .HasColumnType("nvarchar(max)")
                    .IsRequired(true);
        }
    }
}
