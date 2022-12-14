// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore;
using EfCoreApp.Models;
using System;

#nullable disable

namespace EfCoreApp.Configuration
{
    public class VýrobkyMateriálConfiguration : IEntityTypeConfiguration<VýrobkyMateriál>
    {
        public void Configure(EntityTypeBuilder<VýrobkyMateriál> entity)
        {
            entity.HasIndex(e => e.IdMateriálu, "IX_VýrobkyMateriál_IdMateriálu");

            entity.HasIndex(e => e.IdVýrobku, "IX_VýrobkyMateriál_IdVýrobku");

            entity.Property(e => e.Id).HasColumnName("ID");

            entity.Property(e => e.IdMateriálu).HasDefaultValueSql("(0)");

            entity.Property(e => e.IdVýrobku).HasDefaultValueSql("(0)");

            entity.Property(e => e.Množstvo).HasDefaultValueSql("(0)");

            entity.Property(e => e.Poznámka).HasColumnType("ntext");

            entity.Property(e => e.Strana)
                .HasMaxLength(3)
                .IsUnicode(false);

            entity.Property(e => e.Výpočet).HasDefaultValueSql("(0)");

            entity.HasOne(d => d.Material)
                .WithMany()
                .HasForeignKey(d => d.IdMateriálu)
                .HasPrincipalKey(p => p.Id)
                .HasConstraintName("VýrobkyMateriál_FK00");

            entity.HasOne(d => d.InternalOrder)
                .WithMany(p => p.MaterialItems)
                .HasForeignKey(d => d.IdVýrobku)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("VýrobkyMateriál_FK01");
        }
    }
}
