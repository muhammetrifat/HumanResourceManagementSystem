using HumanResourceManagementSystem.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HumanResourceManagementSystem.Persistence.Configurations;

public class CountryConfiguration : IEntityTypeConfiguration<Country>
{
	public void Configure(EntityTypeBuilder<Country> builder)
	{
		// Primary key
		builder.HasKey(e => e.Id);

		// Relationships

		// One-to-many relationship with City
		builder.HasMany(e => e.Cities)
			.WithOne(r => r.Country)
			.HasForeignKey(e => e.CountryId)
			.OnDelete(DeleteBehavior.Cascade);

		// One-to-many relationship with Address
		builder.HasMany(e => e.Addresses)
			.WithOne(r => r.Country)
			.HasForeignKey(e => e.CountryId)
			.OnDelete(DeleteBehavior.Cascade);

		// Validation rules
		builder.Property(e => e.Name)
			.IsRequired()
			.HasMaxLength(100);

		builder.Property(e => e.Code)
			.IsRequired()
			.HasMaxLength(20);
	}
}

