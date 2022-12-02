using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore;
using EfCoreApp.Models.Custom;
using System;

namespace EfCoreApp.Configuration.Custom;

public class ProductListViewConfiguration : IEntityTypeConfiguration<ProductListView>
{
    public void Configure(EntityTypeBuilder<ProductListView> entity)
    {
        entity.ToView("ProductListView", "manufacture");

        entity.HasKey(e => e.Id);

     

        entity.HasMany(e => e.MaterialItems)
            .WithOne()
            .HasForeignKey(d => d.IdVýrobku)
            .HasPrincipalKey(p => p.Id);

        entity.HasMany(e => e.InternalOrders)
            .WithOne()
            .HasForeignKey(d => d.Kód)
            .HasPrincipalKey(p => p.Kód);
    }
}


