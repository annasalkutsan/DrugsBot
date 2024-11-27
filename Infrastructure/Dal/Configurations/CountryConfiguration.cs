using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Dal.Configurations;

/// <summary>
/// Конфигурация для сущности <see cref="Country"/>
/// </summary>
public class CountryConfiguration:IEntityTypeConfiguration<Country>
{
    public void Configure(EntityTypeBuilder<Country> builder)
    {
        builder.ToTable(nameof(Country));
        
        builder.Property(c => c.Id).IsRequired();
        builder.HasKey(c => c.Id);
        
        builder.Property(c => c.Name).IsRequired().HasMaxLength(100);
        builder.Property(c => c.Code).IsRequired().HasMaxLength(2);
        
        // Связь с DrugItems (один ко многим)
        builder.HasMany(c => c.Drugs)
            .WithOne(d=>d.Country)
            .HasForeignKey(d => d.CountryCodeId);
    }
}