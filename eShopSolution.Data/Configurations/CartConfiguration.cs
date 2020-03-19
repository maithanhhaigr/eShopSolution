﻿using eShopSolution.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Configurations
{
    public class CartConfiguration : IEntityTypeConfiguration<Cart>
    {
        public void Configure(EntityTypeBuilder<Cart> builder)
        {
            builder.ToTable("Carts");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).UseIdentityColumn();

            builder.Property(x => x.Price).IsRequired();

            builder.HasOne(t => t.Product).WithMany(tc => tc.Carts)
                .HasForeignKey(tc => tc.ProductId);

            builder.HasOne(t => t.AppUser).WithMany(tc => tc.Carts)
                .HasForeignKey(tc => tc.UserId);
        }
    }
}
