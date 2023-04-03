using HumanResourceManagementSystem.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HumanResourceManagementSystem.Persistence.Configurations;

public class ProjectConfiguration : IEntityTypeConfiguration<Project>
{
	public void Configure(EntityTypeBuilder<Project> builder)
	{
		// Primary key
		builder.HasKey(p => p.Id);

		// Relationships

		// One-to-many relationship with Resume
		builder.HasOne(p => p.Resume)
			.WithMany(r => r.Projects)
			.HasForeignKey(p => p.ResumeId)
			.OnDelete(DeleteBehavior.Cascade);

		// Validation rules
		builder.Property(p => p.Name)
			.IsRequired()
			.HasMaxLength(100);

		builder.Property(p => p.Description)
			.IsRequired()
			.HasMaxLength(1000);

		builder.Property(e => e.StartDate)
			.IsRequired()
			.HasColumnType("datetime2");

		builder.Property(e => e.EndDate)
			.IsRequired(false)
			.HasColumnType("datetime2");

		builder.Property(p => p.Url)
			.IsRequired(false)
			.HasMaxLength(100);
	}
}


