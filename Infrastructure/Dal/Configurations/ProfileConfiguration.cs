using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Dal.Configurations;

/// <summary>
/// Конфигурация для сущности <see cref="Profile"/>
/// </summary>
public class ProfileConfiguration:IEntityTypeConfiguration<Profile>
{
    public void Configure(EntityTypeBuilder<Profile> builder)
    {
        builder.ToTable(nameof(Profile));
        
        builder.Property(p => p.Id).IsRequired();
        builder.HasKey(p => p.Id);

        builder.Property(p => p.ExternalId).IsRequired().HasMaxLength(100);
        builder.OwnsOne(p => p.Email, email =>
        {
            email.Property(e => e.Value).IsRequired().HasMaxLength(255); 
        });
        
        builder.HasMany(p => p.FavoriteDrugs)
            .WithOne(f => f.Profile)
            .HasForeignKey(f => f.ProfileId);
    }
}