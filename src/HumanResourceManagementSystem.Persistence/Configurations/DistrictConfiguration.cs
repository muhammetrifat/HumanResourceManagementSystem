using HumanResourceManagementSystem.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HumanResourceManagementSystem.Persistence.Configurations;

public class DistrictConfiguration : IEntityTypeConfiguration<District>
{
	public void Configure(EntityTypeBuilder<District> builder)
	{
		// Primary key
		builder.HasKey(e => e.Id);

		// Relationships


		// One-to-many relationship with City
		builder.HasOne(e => e.City)
			.WithMany(r => r.Districts)
			.HasForeignKey(e => e.CityId)
			.OnDelete(DeleteBehavior.Cascade);

		// One-to-many relationship with Address
		builder.HasMany(e => e.Addresses)
			.WithOne(r => r.District)
			.HasForeignKey(e => e.DistrictId)
			.OnDelete(DeleteBehavior.Cascade);

		// Validation rules
		builder.Property(e => e.Name)
			.IsRequired()
			.HasMaxLength(100);
	}
}

