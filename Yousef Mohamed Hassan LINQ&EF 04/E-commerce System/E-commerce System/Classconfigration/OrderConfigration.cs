using E_commerce_System.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E_commerce_System.Models;


namespace E_commerce_System.Classconfigration
{
    internal class OrderConfigration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> O)
        {
            O.ToTable("Orders");

            O.HasKey(x => x.Id);
            O.Property(c => c.Id)
                .UseIdentityColumn(1, 1);

            O.HasMany(OD=>OD.orderproducts)
                .WithOne(o=>o.order)
                .HasForeignKey(o => o.orderId)
                .OnDelete(DeleteBehavior.Restrict);

            O.HasOne(o => o.customer)
                .WithMany(c => c.orders)
                .HasForeignKey(o => o.CustomerId)
                .OnDelete(DeleteBehavior.Restrict);


        }
    }
}
