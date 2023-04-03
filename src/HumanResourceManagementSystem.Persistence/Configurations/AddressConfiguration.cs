using HumanResourceManagementSystem.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HumanResourceManagementSystem.Persistence.Configurations;

public class AddressConfiguration : IEntityTypeConfiguration<Address>
{
	public void Configure(EntityTypeBuilder<Address> builder)
	{
		// Primary key
		builder.HasKey(e => e.Id);

		// Relationships

		// One-to-many relationship with Country
		builder.HasOne(e => e.Country)
			.WithMany(r => r.Addresses)
			.HasForeignKey(e => e.CountryId)
			.OnDelete(DeleteBehavior.Cascade);

		// One-to-many relationship with City
		builder.HasOne(e => e.City)
			.WithMany(r => r.Addresses)
			.HasForeignKey(e => e.CityId)
			.OnDelete(DeleteBehavior.Cascade);

		// One-to-many relationship with District
		builder.HasOne(e => e.District)
			.WithMany(r => r.Addresses)
			.HasForeignKey(e => e.DistrictId)
			.OnDelete(DeleteBehavior.Cascade);

		// One-to-one relationship with Resume
		builder.HasOne(e => e.Resume)
			.WithOne(r => r.Address)
			.HasForeignKey<Address>(e => e.ResumeId)
			.OnDelete(DeleteBehavior.Cascade);

		// One-to-one relationship with Company
		builder.HasOne(e => e.Company)
			.WithOne(r => r.Address)
			.HasForeignKey<Address>(e => e.CompanyId)
			.OnDelete(DeleteBehavior.Cascade);

		// Validation rules

		builder.Property(e => e.Description)
			.IsRequired()
			.HasMaxLength(500);

		builder.Property(e => e.IsUser)
			.IsRequired()
			.HasColumnType("bit")
			.HasDefaultValue(false);

		builder.Property(e => e.IsCompany)
			.IsRequired()
			.HasColumnType("bit")
			.HasDefaultValue(false);
	}
}

