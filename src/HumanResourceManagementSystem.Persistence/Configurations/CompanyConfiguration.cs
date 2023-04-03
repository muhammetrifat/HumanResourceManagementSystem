using HumanResourceManagementSystem.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace HumanResourceManagementSystem.Persistence.Configurations;

public class CompanyConfiguration : IEntityTypeConfiguration<Company>
{
	public void Configure(EntityTypeBuilder<Company> builder)
	{
		// Primary key
		builder.HasKey(e => e.Id);

		// Relationships

		// One-to-one relationship with Address
		builder.HasOne(e => e.Address)
			.WithOne(r => r.Company)
			.HasForeignKey<Company>(e => e.AddressId)
			.OnDelete(DeleteBehavior.Cascade);

		// One-to-many relationship with User
		builder.HasMany(e => e.Users)
			.WithOne(r => r.Company)
			.HasForeignKey(e => e.CompanyId)
			.OnDelete(DeleteBehavior.Cascade);

		// One-to-many relationship with Advertisement
		builder.HasMany(e => e.Advertisements)
			.WithOne(r => r.Company)
			.HasForeignKey(e => e.CompanyId)
			.OnDelete(DeleteBehavior.Cascade);

		// One-to-many relationship with SectorsOfCompanies
		builder.HasMany(e => e.SectorsOfCompanies)
			.WithOne(r => r.Company)
			.HasForeignKey(e => e.CompanyId)
			.OnDelete(DeleteBehavior.Cascade);

		// One-to-many relationship with JobApplications
		builder.HasMany(e => e.JobApplications)
			.WithOne(r => r.Company)
			.HasForeignKey(e => e.CompanyId)
			.OnDelete(DeleteBehavior.Cascade);


		// Validation rules
		builder.Property(e => e.Name)
			.IsRequired()
			.HasMaxLength(100);

		builder.Property(e => e.About)
			.IsRequired()
			.HasMaxLength(1000);

		builder.Property(e => e.NumberOfEmployees)
			.IsRequired()
			.HasColumnType("int")
			.HasDefaultValue(0);

		builder.Property(e => e.Benefits)
			.IsRequired(false)
			.HasMaxLength(2000);

		builder.Property(e => e.WebSiteUrl)
			.IsRequired(false)
			.HasMaxLength(200);

		builder.Property(e => e.TaxNumber)
			.IsRequired()
			.HasMaxLength(20);

	}
}

