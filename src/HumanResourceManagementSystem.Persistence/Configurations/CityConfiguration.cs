using HumanResourceManagementSystem.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HumanResourceManagementSystem.Persistence.Configurations;

public class CityConfiguration : IEntityTypeConfiguration<City>
{
	public void Configure(EntityTypeBuilder<City> builder)
	{
		// Primary key
		builder.HasKey(e => e.Id);

		// Relationships

		// One-to-many relationship with Country
		builder.HasOne(e => e.Country)
			.WithMany(r => r.Cities)
			.HasForeignKey(e => e.CountryId)
			.OnDelete(DeleteBehavior.Cascade);

		// One-to-many relationship with District
		builder.HasMany(e => e.Districts)
			.WithOne(r => r.City)
			.HasForeignKey(e => e.CityId)
			.OnDelete(DeleteBehavior.Cascade);

		// One-to-many relationship with Address
		builder.HasMany(e => e.Addresses)
			.WithOne(r => r.City)
			.HasForeignKey(e => e.CountryId)
			.OnDelete(DeleteBehavior.Cascade);

		// Validation rules
		builder.Property(e => e.Name)
			.IsRequired()
			.HasMaxLength(100);
	}
}