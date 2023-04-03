using HumanResourceManagementSystem.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HumanResourceManagementSystem.Persistence.Configurations;

public class JobApplicationConfiguration : IEntityTypeConfiguration<JobApplication>
{
	public void Configure(EntityTypeBuilder<JobApplication> builder)
	{
		// Primary Key
		builder.HasKey(x => x.Id);

		// Relationships

		// One-to-many relationship with Advertisement
		builder.HasOne(x => x.Advertisement)
			.WithMany(x => x.JobApplications)
			.HasForeignKey(x => x.AdvertisementId)
			.OnDelete(DeleteBehavior.Cascade);

		// One-to-many relationship with Company
		builder.HasOne(x => x.Company)
			.WithMany(x => x.JobApplications)
			.HasForeignKey(x => x.CompanyId)
			.OnDelete(DeleteBehavior.Cascade);

		// One-to-many relationship with Resume
		builder.HasOne(x => x.Resume)
			.WithMany(x => x.JobApplications)
			.HasForeignKey(x => x.ResumeId)
			.OnDelete(DeleteBehavior.Cascade);

		// One-to-many relationship with ResumeCv
		builder.HasOne(x => x.ResumeCv)
			.WithMany(x => x.JobApplications)
			.HasForeignKey(x => x.ResumeCvId)
			.OnDelete(DeleteBehavior.Cascade);
	}
}


