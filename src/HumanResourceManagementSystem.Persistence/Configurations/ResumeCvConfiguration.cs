using HumanResourceManagementSystem.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HumanResourceManagementSystem.Persistence.Configurations;

public class ResumeCvConfiguration : IEntityTypeConfiguration<ResumeCv>
{
	public void Configure(EntityTypeBuilder<ResumeCv> builder)
	{
		// Primary key
		builder.HasKey(e => e.Id);

		// Relationships

		// One-to-one relationship with Resume
		builder.HasOne(e => e.Resume)
			.WithOne(r => r.ResumeCv)
			.HasForeignKey<Resume>(e => e.ResumeCvId)
			.OnDelete(DeleteBehavior.Cascade);

		// One-to-many relationship with JobApplication
		builder.HasMany(e => e.JobApplications)
			.WithOne(r => r.ResumeCv)
			.HasForeignKey(e => e.ResumeCvId)
			.OnDelete(DeleteBehavior.Cascade);


		
		// Validation rules

		builder.Property(e => e.FileName)
			.IsRequired()
			.HasMaxLength(255);

		builder.Property(e => e.FileExtension)
			.IsRequired()
			.HasMaxLength(10);

		builder.Property(f => f.File)
			.IsRequired()
			.IsRowVersion();


	}
}


