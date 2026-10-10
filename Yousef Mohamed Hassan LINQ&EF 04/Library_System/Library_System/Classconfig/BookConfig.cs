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
    internal class BookConfig : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> B)
        {

            B.ToTable("Books");

            B.HasKey(b => b.Id);
            B.Property(b => b.Id)
                .UseIdentityColumn(1, 1);

            B.Property(b => b.Title)
                .HasColumnType("nvarchar(max)")
                .IsRequired(true);

            B.HasOne(b => b.Author)
                .WithMany(a => a.Books)
                .HasForeignKey(b => b.AuthorId)
                .OnDelete(DeleteBehavior.Restrict);


        }
    }
}
