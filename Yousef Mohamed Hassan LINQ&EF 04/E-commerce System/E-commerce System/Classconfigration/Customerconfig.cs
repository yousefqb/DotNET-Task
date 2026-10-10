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
    internal class Customerconfig : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> C)
        {
            C.ToTable("Customers");

            C.HasKey(x => x.Id);
            C.Property(c => c.Id)
                .UseIdentityColumn(1, 1);

            C.Property(p => p.Name)
                .HasColumnType("nvarchar(max)")
                .HasColumnName("Product_Name")
                .IsRequired(true);
        }
    }
}
