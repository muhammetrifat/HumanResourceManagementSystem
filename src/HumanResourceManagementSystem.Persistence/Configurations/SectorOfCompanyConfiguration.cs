using HumanResourceManagementSystem.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HumanResourceManagementSystem.Persistence.Configurations;

public class SectorOfCompanyConfiguration : IEntityTypeConfiguration<SectorsOfCompanies>
{
	public void Configure(EntityTypeBuilder<SectorsOfCompanies> builder)
	{
		// Primary key with Id
		builder.HasKey(e => e.Id);


		// Relationships

		// Many-to-one relationship with Company
		builder.HasOne(e => e.Company)
			.WithMany(r => r.SectorsOfCompanies)
			.HasForeignKey(e => e.CompanyId)
			.OnDelete(DeleteBehavior.Cascade);

		// Many-to-one relationship with Sector
		builder.HasOne(e => e.Sector)
			.WithMany(r => r.SectorsOfCompanies)
			.HasForeignKey(e => e.SectorId)
			.OnDelete(DeleteBehavior.Cascade);

	}
}


