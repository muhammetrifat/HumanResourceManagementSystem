using HumanResourceManagementSystem.Domain.Entities;
using HumanResourceManagementSystem.Domain.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HumanResourceManagementSystem.Persistence.Configurations;

public class ProfileConfiguration : IEntityTypeConfiguration<Profile>
{
	public void Configure(EntityTypeBuilder<Profile> builder)
	{
		// Primary key
		builder.HasKey(p => p.Id);

		// Relationships

		// One-to-one relationship with Resume
		builder.HasOne(p => p.Resume)
			.WithOne(r => r.Profile)
			.HasForeignKey<Profile>(p => p.ResumeId)
			.OnDelete(DeleteBehavior.Cascade);

		// Validation rules
		builder.Property(p => p.FirstName)
			.IsRequired()
			.HasMaxLength(100);

		builder.Property(p => p.LastName)
			.IsRequired()
			.HasMaxLength(100);

		builder.Property(p => p.About)
			.HasMaxLength(1000);

		builder.Property(p => p.Email)
			.IsRequired()
			.HasMaxLength(100);

		builder.Property(p => p.Age)
			.IsRequired()
			.HasColumnType("int")
			.HasDefaultValue(0);

		builder.Property(p => p.Gender)
			.HasConversion(g => (int)g, g => (Genders)g)
			.HasColumnType("int")
			.IsRequired();

		builder.Property(p => p.BirthDate)
			.IsRequired()
			.HasColumnType("datetime2");

		builder.Property(p => p.WebSiteUrl)
			.HasMaxLength(100);
	}
}


