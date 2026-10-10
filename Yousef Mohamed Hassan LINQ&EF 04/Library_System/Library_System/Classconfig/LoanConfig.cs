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
    internal class LoanConfig : IEntityTypeConfiguration<Loan>
    {
        public void Configure(EntityTypeBuilder<Loan> L)
        {
            L.ToTable("Loans");
            L.HasKey(l => new { l.BorrowerId, l.BookId });

            L.HasOne(l => l.Borrower)
                .WithMany(b => b.BorrowerBooks)
                .HasForeignKey(l => l.BorrowerId)
                .OnDelete(DeleteBehavior.Restrict);

            L.HasOne(l => l.Book)
                .WithMany(b => b.BookBorrowers)
                .HasForeignKey(l => l.BookId)
                .OnDelete(DeleteBehavior.Restrict);

        }
    }
}
