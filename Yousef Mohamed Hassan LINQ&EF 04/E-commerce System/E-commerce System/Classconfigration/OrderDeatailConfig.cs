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
    internal class OrderDeatailConfig : IEntityTypeConfiguration<OrderDetail>
    {
        public void Configure(EntityTypeBuilder<OrderDetail> OD)
        {
            OD.ToTable("OrderDetails");
            OD.HasKey(od=>new { od.orderId, od.productId });
        }
    }
}
