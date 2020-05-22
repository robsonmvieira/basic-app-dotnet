using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Store.Business.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Store.Data.Mapping
{
    class SupplierMapping : IEntityTypeConfiguration<Supplier>
    {
        public void Configure(EntityTypeBuilder<Supplier> builder)
        {
            builder.HasKey(s => s.Id);

            builder.Property(s => s.Doc).IsRequired().HasColumnType("varchar(20)");


            builder.HasOne(s => s.Address)
                .WithOne(a => a.Supplier);

            builder.HasMany(s => s.Products)
                .WithOne(p => p.Supplier)
                .HasForeignKey(p => p.SupplierId);

            builder.ToTable("suppliers");
        }
    }
}
