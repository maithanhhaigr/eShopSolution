using eShopSolution.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Configurations
{
    public class OrderDetailConfiguration : IEntityTypeConfiguration<OrderDetail>
    {
        public void Configure(EntityTypeBuilder<OrderDetail> builder)
        {
            builder.ToTable("OrderDetails");

            builder.HasKey(t => new { t.OrderId, t.ProductId });

            builder.HasOne(t => t.Order).WithMany(tc => tc.OrderDetails)
                .HasForeignKey(tc => tc.OrderId);

            builder.HasOne(t => t.Product).WithMany(tc => tc.OrderDetails)
                .HasForeignKey(tc => tc.ProductId);
        }
    }
}
