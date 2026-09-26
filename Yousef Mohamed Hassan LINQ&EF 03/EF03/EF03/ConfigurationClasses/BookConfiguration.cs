using EF03.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF03.ConfigurationClasses
{
    internal class BookConfiguration : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            //table
            builder.ToTable("Book");

            //id
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn(10, 10);

            //title
            builder.Property(x=>x.Title)
                    .IsRequired(true)
                    .HasMaxLength(100);

            //price
            builder.Property(x => x.Price).HasColumnType("decimal(8,2)");

            //publishdate
            builder.Property(x => x.PublishedDate)
                   .IsRequired(false);


        }
    }
}
