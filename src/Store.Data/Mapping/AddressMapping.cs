﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Store.Business.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Store.Data.Mapping
{
    public class AddressMapping : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.HasKey(a => a.Id);

            builder.Property(a => a.Street)
                .IsRequired()
                .HasColumnType("varchar(200)");

            builder.Property(a => a.Number)
                .IsRequired()
                .HasColumnType("varchar(10)");

            builder.Property(a => a.Complement)
                .IsRequired()
                .HasColumnType("varchar(200)");

            builder.Property(a => a.ZipCode)
                .IsRequired()
                .HasColumnType("varchar(10)");

            builder.Property(a => a.Neighborhood)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.Property(a => a.City)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.Property(a => a.State)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.ToTable("Addresses");
        }
    }
}

/*

    
        public string City { get; set; }
        public string State { get; set; }
        public bool Active { get; set; }
        public Supplier Supplier { get; set; }
 */
