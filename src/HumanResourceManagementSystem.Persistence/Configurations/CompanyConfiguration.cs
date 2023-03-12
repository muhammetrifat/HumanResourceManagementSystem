using HumanResourceManagementSystem.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace HumanResourceManagementSystem.Persistence.Configurations;

public class CompanyConfiguration : IEntityTypeConfiguration<Company>
{
	public void Configure(EntityTypeBuilder<Company> builder)
	{
		builder.Property(e => e.Name)
			.IsRequired()
			.HasMaxLength(100);

		builder.Property(e => e.About)
			.IsRequired()
			.HasMaxLength(1000);

		builder.Property(e => e.NumberOfEmployees)
			.IsRequired();

		builder.Property(e => e.Benefits)
			.HasMaxLength(1000);

		builder.Property(e => e.WebSiteUrl)
			.HasMaxLength(100);

		builder.Property(e => e.AddressId)
			.IsRequired();

		builder.Property(e => e.TaxNumber)
			.IsRequired()
			.HasMaxLength(100);

		builder.HasMany(e => e.Users)
			.WithOne(e => e.Company)
			.HasForeignKey(e => e.CompanyId);

		// TODO: burada adres tablosunun ilişkileri ile ilgili işlemler yapılacak
	}
}

