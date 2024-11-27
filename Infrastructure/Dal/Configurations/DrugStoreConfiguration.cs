using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Dal.Configurations;

/// <summary>
/// Конфигурация для сущности <see cref="DrugStore"/>
/// </summary>
public class DrugStoreConfiguration:IEntityTypeConfiguration<DrugStore>
{
    public void Configure(EntityTypeBuilder<DrugStore> builder)
    {
        builder.ToTable(nameof(DrugStore));
        
        builder.Property(d => d.Id).IsRequired();
        builder.HasKey(d => d.Id);

        builder.Property(d => d.DrugNetwork).IsRequired().HasMaxLength(100);
        builder.Property(d => d.Number);
        builder.Property(d => d.PhoneNumber);
        builder.OwnsOne(d => d.Address, a =>
        {
            a.Property(ad => ad.City).IsRequired().HasMaxLength(50);
            a.Property(ad => ad.Street).IsRequired().HasMaxLength(100);
            a.Property(ad => ad.House).IsRequired().HasMaxLength(10);
        });
        
        builder.HasMany(d => d.DrugItems)
            .WithOne(d => d.DrugStore)
            .HasForeignKey(d => d.DrugStoreId);
    }
}