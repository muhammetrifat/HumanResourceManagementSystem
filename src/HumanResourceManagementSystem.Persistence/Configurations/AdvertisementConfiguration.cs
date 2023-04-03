using HumanResourceManagementSystem.Domain.Entities;
using HumanResourceManagementSystem.Domain.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Security.Cryptography.X509Certificates;

namespace HumanResourceManagementSystem.Persistence.Configurations;

public class AdvertisementConfiguration : IEntityTypeConfiguration<Advertisement>
{
	public void Configure(EntityTypeBuilder<Advertisement> builder)
	{
		// Primary key
		builder.HasKey(e => e.Id);

		// Relationships

		// One-to-many relationship with Company
		builder.HasOne(e => e.Company)
			.WithMany(r => r.Advertisements)
			.HasForeignKey(e => e.CompanyId)
			.OnDelete(DeleteBehavior.Cascade);

		// One-to-many relationship with Department
		builder.HasOne(e => e.Department)
			.WithMany(r => r.Advertisements)
			.HasForeignKey(e => e.DepartmentId)
			.OnDelete(DeleteBehavior.Cascade);

		// One-to-many relationship with JobApplication
		builder.HasMany(e => e.JobApplications)
			.WithOne(r => r.Advertisement)
			.HasForeignKey(e => e.AdvertisementId)
			.OnDelete(DeleteBehavior.Cascade);

		// One-to-many relationship with User
		builder.HasOne(e => e.User)
			.WithMany(r => r.Advertisements)
			.HasForeignKey(e => e.CreatedBy)
			.OnDelete(DeleteBehavior.Cascade);

		// Validation rules

		builder.Property(e => e.ExperienceStart)
			.HasColumnType("decimal(5,2)")
			.IsRequired();

		builder.Property(e => e.ExperienceEnd)
			.HasColumnType("decimal(5,2)")
			.IsRequired();

		builder.Property(e => e.Description)
			.IsRequired()
			.HasMaxLength(1000);

		builder.Property(e => e.IsCvRequired)
			.IsRequired()
			.HasColumnType("bit")
			.HasDefaultValue(false);

		builder.Property(e => e.WorkType)
			.HasConversion(w => (int)w, w => (WorkTypes)w)
			.HasColumnType("int")
			.IsRequired();
	}
}