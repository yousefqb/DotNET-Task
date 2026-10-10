using Library_System.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_System.Classconfig
{
    internal class Borrowerconfig : IEntityTypeConfiguration<Borrower>
    {
        public void Configure(EntityTypeBuilder<Borrower> B)
        {
            B.ToTable("Borrowers");

            B.HasKey(b => b.Id);
            B.Property(b => b.Id)
                .UseIdentityColumn(1, 1);

            B.Property(b => b.Name)
                .HasColumnType("nvarchar(max)")
                .IsRequired(true);
        }
    }
}
