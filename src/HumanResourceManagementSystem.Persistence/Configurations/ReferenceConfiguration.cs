using HumanResourceManagementSystem.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HumanResourceManagementSystem.Persistence.Configurations;

public class ReferenceConfiguration : IEntityTypeConfiguration<Reference>
{
	public void Configure(EntityTypeBuilder<Reference> builder)
	{
		// Primary key
		builder.HasKey(r => r.Id);

		// Relationships

		// One-to-many relationship with Resume
		builder.HasOne(r => r.Resume)
			.WithMany(r => r.References)
			.HasForeignKey(r => r.ResumeId)
			.OnDelete(DeleteBehavior.Cascade);

		// Validation rules
		builder.Property(r => r.FirstName)
			.IsRequired()
			.HasMaxLength(100);

		builder.Property(r => r.LastName)
			.IsRequired()
			.HasMaxLength(100);

		builder.Property(r => r.Email)
			.IsRequired()
			.HasMaxLength(50);

		builder.Property(r => r.Phone)
			.IsRequired()
			.HasMaxLength(50);

		builder.Property(r => r.CompanyName)
			.IsRequired()
			.HasMaxLength(200);

		builder.Property(r => r.PositionName)
			.IsRequired()
			.HasMaxLength(100);
	}
}


