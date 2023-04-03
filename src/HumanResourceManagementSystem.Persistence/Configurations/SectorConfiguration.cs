using HumanResourceManagementSystem.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HumanResourceManagementSystem.Persistence.Configurations;

public class SectorConfiguration : IEntityTypeConfiguration<Sector>
{
	public void Configure(EntityTypeBuilder<Sector> builder)
	{
		// Primary key
		builder.HasKey(e => e.Id);

		// Relationships

		// One-to-many relationship with SectorsOfCompanies
		builder.HasMany(e => e.SectorsOfCompanies)
			.WithOne(r => r.Sector)
			.HasForeignKey(e => e.SectorId)
			.OnDelete(DeleteBehavior.Cascade);

		// One-to-many relationship with Experience
		builder.HasMany(e => e.Experiences)
			.WithOne(r => r.Sector)
			.HasForeignKey(e => e.SectorId)
			.OnDelete(DeleteBehavior.Cascade);

		// Validation rules
		builder.Property(e => e.Name)
			.IsRequired()
			.HasMaxLength(100);
	}
}


