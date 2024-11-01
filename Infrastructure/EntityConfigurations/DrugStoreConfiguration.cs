using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.EntityConfigurations;

public class DrugStoreConfiguration : IEntityTypeConfiguration<DrugStore>
{
    public void Configure(EntityTypeBuilder<DrugStore> builder)
    {
        builder.HasKey(ds => ds.Id);
        builder.Property(ds => ds.DrugNetwork).IsRequired();
        builder.Property(ds => ds.Number).IsRequired();

        builder.OwnsOne(ds => ds.Address, a =>
        {
            a.Property(ad => ad.City).IsRequired();
            a.Property(ad => ad.Street).IsRequired();
            a.Property(ad => ad.House).IsRequired();
        });

        builder.Property(ds => ds.PhoneNumber).IsRequired();
    }
}