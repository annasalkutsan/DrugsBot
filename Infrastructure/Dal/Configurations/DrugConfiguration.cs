using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Dal.Configurations;

/// <summary>
/// Конфигурация для сущности <see cref="Drug"/>
/// </summary>
public class DrugConfiguration:IEntityTypeConfiguration<Drug> 
{
    public void Configure(EntityTypeBuilder<Drug> builder)
    {
        builder.ToTable(nameof(Drug));
        
        builder.Property(d => d.Id).IsRequired();
        builder.HasKey(d => d.Id);
        
        builder.Property(d => d.Name).IsRequired().HasMaxLength(150);
        builder.Property(d => d.Manufacturer).IsRequired().HasMaxLength(100);
        builder.Property(d => d.CountryCodeId).IsRequired();
        
        builder.HasOne(d => d.Country)
            .WithMany(c => c.Drugs) 
            .HasForeignKey(d => d.CountryCodeId);
        
        builder.HasMany(d => d.DrugItems)
            .WithOne(d => d.Drug)
            .HasForeignKey(d => d.DrugId);
    }
}