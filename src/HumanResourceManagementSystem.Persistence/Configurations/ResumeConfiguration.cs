using HumanResourceManagementSystem.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HumanResourceManagementSystem.Persistence.Configurations;

public class ResumeConfiguration : IEntityTypeConfiguration<Resume>
{
	public void Configure(EntityTypeBuilder<Resume> builder)
	{
		// Primary Key
		builder.HasKey(r => r.Id);

		// One-to-one relationship with User
		builder.HasOne(r => r.User)
			.WithOne(u => u.Resume)
			.HasForeignKey<Resume>(r => r.UserId);

		// One-to-one relationship with Address
		builder.HasOne(r => r.Address)
			.WithOne(u => u.Resume)
			.HasForeignKey<Resume>(r => r.AddressId);

		// One-to-many relationship with Skill
		builder.HasMany(r => r.Skills)
			.WithOne(s => s.Resume)
			.HasForeignKey(s => s.ResumeId);

		// One-to-many relationship with Language
		builder.HasMany(r => r.Languages)
			.WithOne(l => l.Resume)
			.HasForeignKey(l => l.ResumeId);

		// One-to-many relationship with Project
		builder.HasMany(r => r.Projects)
			.WithOne(p => p.Resume)
			.HasForeignKey(p => p.ResumeId);

		// One-to-one relationship with Profile
		builder.HasOne(r => r.Profile)
			.WithOne(p => p.Resume)
			.HasForeignKey<Profile>(p => p.ResumeId);

		// One-to-one relationship with ResumeCv
		builder.HasOne(r => r.ResumeCv)
			.WithOne(r => r.Resume)
			.HasForeignKey<ResumeCv>(r => r.ResumeId);

		// One-to-many relationship with Experience
		builder.HasMany(r => r.Experiences)
			.WithOne(e => e.Resume)
			.HasForeignKey(e => e.ResumeId);

		// One-to-many relationship with Reference
		builder.HasMany(r => r.References)
			.WithOne(rf => rf.Resume)
			.HasForeignKey(rf => rf.ResumeId);

		// One-to-many relationship with Education
		builder.HasMany(r => r.Educations)
			.WithOne(e => e.Resume)
			.HasForeignKey(e => e.ResumeId);

		// One-to-many relationship with Certificate
		builder.HasMany(r => r.Certificates)
			.WithOne(c => c.Resume)
			.HasForeignKey(c => c.ResumeId);
	}
}


