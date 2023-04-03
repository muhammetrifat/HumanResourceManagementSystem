using HumanResourceManagementSystem.Domain.Entities;
using HumanResourceManagementSystem.Domain.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HumanResourceManagementSystem.Persistence.Configurations;

public class LanguageConfiguration : IEntityTypeConfiguration<Language>
{
	public void Configure(EntityTypeBuilder<Language> builder)
	{
		// Primary key
		builder.HasKey(l => l.Id);

		// Relationships

		// One-to-many relationship with Resume
		builder.HasOne(l => l.Resume)
			.WithMany(r => r.Languages)
			.HasForeignKey(l => l.ResumeId)
			.OnDelete(DeleteBehavior.Cascade);

		// Validation rules
		builder.Property(l => l.Name)
			.IsRequired()
			.HasMaxLength(100);

		builder.Property(l => l.Level)
			.HasConversion(l => (int)l, l => (LanguageLevels)l)
			.HasColumnType("int")
			.IsRequired();
	}
}


