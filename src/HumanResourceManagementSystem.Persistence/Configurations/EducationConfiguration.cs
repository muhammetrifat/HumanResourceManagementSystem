using HumanResourceManagementSystem.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HumanResourceManagementSystem.Persistence.Configurations;

public class EducationConfiguration : IEntityTypeConfiguration<Education>
{
	public void Configure(EntityTypeBuilder<Education> builder)
	{
		// Primary key
		builder.HasKey(e => e.Id);

		// Relationships

		// One-to-many relationship with Resume
		builder.HasOne(e => e.Resume)
			.WithMany(r => r.Educations)
			.HasForeignKey(e => e.ResumeId)
			.OnDelete(DeleteBehavior.Cascade);

		// Validation rules
		builder.Property(e => e.Name)
			.IsRequired()
			.HasMaxLength(100);

		builder.Property(e => e.SectionName)
			.IsRequired()
			.HasMaxLength(100);

		builder.Property(e => e.StartDate)
			.IsRequired()
			.HasColumnType("datetime2");

		builder.Property(e => e.EndDate)
			.IsRequired(false)
			.HasColumnType("datetime2");

		builder.Property(e => e.GradeAverage)
			.HasColumnType("decimal(5,2)")
			.IsRequired();


	}
}


