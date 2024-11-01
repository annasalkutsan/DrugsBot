using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.EntityConfigurations;

public class DrugConfiguration : IEntityTypeConfiguration<Drug>
{
    public void Configure(EntityTypeBuilder<Drug> builder)
    {
        builder.HasKey(d => d.Id);
        builder.Property(d => d.Name).IsRequired();
        builder.Property(d => d.Manufacturer).IsRequired();

        // Связь с Country по CountryCodeId
        builder
            .HasOne(d => d.Country)
            .WithMany(c => c.Drugs)
            .HasForeignKey(d => d.CountryCodeId)
            .HasPrincipalKey(c => c.Code)
            .OnDelete(DeleteBehavior.Restrict);
    }
}