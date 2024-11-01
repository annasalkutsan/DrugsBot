using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.EntityConfigurations;

public class DrugItemConfiguration : IEntityTypeConfiguration<DrugItem>
{
    public void Configure(EntityTypeBuilder<DrugItem> builder)
    {
        builder.HasKey(di => di.Id);
        builder.Property(di => di.Cost).IsRequired();
        builder.Property(di => di.Count).IsRequired();

        // Связь с Drug
        builder
            .HasOne(di => di.Drug)
            .WithMany(d => d.DrugItems)
            .HasForeignKey(di => di.DrugId)
            .OnDelete(DeleteBehavior.Cascade);

        // Связь с DrugStore
        builder
            .HasOne(di => di.DrugStore)
            .WithMany(ds => ds.DrugItems)
            .HasForeignKey(di => di.DrugstoreId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}