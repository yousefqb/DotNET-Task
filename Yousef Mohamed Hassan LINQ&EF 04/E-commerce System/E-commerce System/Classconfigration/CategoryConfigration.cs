using E_commerce_System.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace E_commerce_System.Classconfigration
{
    internal class CategoryConfigration : IEntityTypeConfiguration<Category>
    {
        
        public void Configure(EntityTypeBuilder<Category> C)
        {
            C.ToTable("Categories");

            C.HasKey(x => x.Id);
            C.Property(c=>c.Id)
                .UseIdentityColumn(1,1);
            C.Property(c => c.Name)
                .HasColumnType("nvarchar(max)")
                .IsRequired(true)
                .HasColumnName("category_Name");
        }
    }
}
