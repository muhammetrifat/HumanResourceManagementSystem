using HumanResourceManagementSystem.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HumanResourceManagementSystem.Persistence.Configurations;

public class SkillConfiguration : IEntityTypeConfiguration<Skill>
{
	public void Configure(EntityTypeBuilder<Skill> builder)
	{
		// Primary key
		builder.HasKey(s => s.Id);

		// Relationships

		// One-to-many relationship with Resume
		builder.HasOne(s => s.Resume)
			.WithMany(r => r.Skills)
			.HasForeignKey(s => s.ResumeId)
			.OnDelete(DeleteBehavior.Cascade);

		// Validation rules
		builder.Property(s => s.Name)
			.IsRequired()
			.HasMaxLength(100);
	}
}


