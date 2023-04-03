using HumanResourceManagementSystem.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HumanResourceManagementSystem.Persistence.Configurations;

public class WorkPositionConfiguration : IEntityTypeConfiguration<WorkPosition>
{
	public void Configure(EntityTypeBuilder<WorkPosition> builder)
	{
		// Primary Key
		builder.HasKey(x => x.Id);

		// Relationships

		// One-to-many relationship with Experience
		builder.HasMany(x => x.Experiences)
			.WithOne(x => x.WorkPosition)
			.HasForeignKey(x => x.WorkPositionId)
			.OnDelete(DeleteBehavior.Cascade);

		// Validation rules

		builder.Property(x => x.Name)
			.IsRequired()
			.HasMaxLength(50);
	}
}


