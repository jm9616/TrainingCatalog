﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Onis.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onis.Infrastructure.DB.Config
{
    public class CatalogItemConfiguration : IEntityTypeConfiguration<CatalogItem>
    {
        public void Configure(EntityTypeBuilder<CatalogItem> builder)
        {
            builder.ToTable("Catalog");


            builder.Property(ci => ci.Id)
                .UseHiLo("catalog_hilo")
                .IsRequired();

            builder.Property(ci => ci.Name)
                   .IsRequired(true)
                   .HasMaxLength(50);

            builder.Property(ci => ci.Price)
                .IsRequired(true)
                .HasColumnType("decimal(18,2)");

            builder.Property(ci => ci.PictureUri)
                .IsRequired(false);

            builder.HasOne(ci => ci.CatalogBrand)
                .WithMany()
                .HasForeignKey(ci => ci.CatalogBrandId);

            builder.HasOne(ci => ci.CatalogType)
                .WithMany()
                .HasForeignKey(ci => ci.CatalogTypeId);
        }
    }
}
