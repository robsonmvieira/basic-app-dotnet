using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Store.Business.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Store.Data.Mapping
{
    public class ProductMapping : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Name).IsRequired()
                .HasColumnType("varchar(200)");
            builder.Property(p => p.Description).IsRequired()
              .HasColumnType("varchar(1000)");
            builder.Property(p => p.Image).IsRequired()
              .HasColumnType("varchar(100)");

            builder.ToTable("Products");
        }
    }
}
