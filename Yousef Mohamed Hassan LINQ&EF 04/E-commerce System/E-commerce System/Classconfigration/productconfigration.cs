using E_commerce_System.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_commerce_System.Classconfigration
{
    internal class productconfigration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> P)
        {
            P.HasKey(p => p.Id);
            P.Property(p => p.Id)
                .UseIdentityColumn(1, 1);

            P.Property(p => p.Name)
                .HasColumnType("nvarchar(max)")
                .HasColumnName("Product_Name")
                .IsRequired(true);

            P.HasOne(p => p.category)
                .WithMany(c => c.products)
                .HasForeignKey(c => c.CategoryId)
                .OnDelete(DeleteBehavior.Restrict);

            P.HasMany(p=>p.productorders)
                .WithOne(po=>po.product)
                .HasForeignKey(po=>po.productId)
                .OnDelete(DeleteBehavior.Restrict);


        }
    }
}
