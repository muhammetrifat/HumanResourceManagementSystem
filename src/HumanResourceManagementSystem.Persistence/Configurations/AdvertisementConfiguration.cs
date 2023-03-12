using HumanResourceManagementSystem.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Security.Cryptography.X509Certificates;

namespace HumanResourceManagementSystem.Persistence.Configurations;

public class AdvertisementConfiguration : IEntityTypeConfiguration<Advertisement>
{
	public void Configure(EntityTypeBuilder<Advertisement> builder)
	{
		builder.Property(e => e.CompanyId)
			.IsRequired();

		builder.Property(e => e.DepartmentId)
			.IsRequired();

		builder.Property(e => e.UserId)
			.IsRequired();

		builder.Property(e => e.ExperienceStart)
			.IsRequired();

		builder.Property(e => e.ExperienceEnd)
			.IsRequired();

		builder.Property(e => e.Description)
			.IsRequired()
			.HasMaxLength(1000);

		builder.Property(e => e.IsCvRequired)
			.HasDefaultValue(false)
			.IsRequired();
		
		builder.Property(e => e.WorkType)
			.IsRequired();

		//foreign keys

		// buraya adres ile ilgili sorunu çözdükten sonra bakacağız
		// hatta her configuration için adres muhabbeti bitince bi fluentapi configurationu yapmamız gerekiyor.



	}
}