using HumanResourceManagementSystem.Domain.Entities;
using HumanResourceManagementSystem.Domain.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace HumanResourceManagementSystem.Persistence.Configurations;

public class ExperienceConfiguration : IEntityTypeConfiguration<Experience>
{
	public void Configure(EntityTypeBuilder<Experience> builder)
	{
		// Primary key
		builder.HasKey(e => e.Id);

		// Relationships

		// One-to-many relationship with Resume
		builder.HasOne(e => e.Resume)
			.WithMany(r => r.Experiences)
			.HasForeignKey(e => e.ResumeId)
			.OnDelete(DeleteBehavior.Cascade);

		// One-to-many relationship with Sector
		builder.HasOne(e => e.Sector)
			.WithMany(s => s.Experiences)
			.HasForeignKey(e => e.ResumeId)
			.OnDelete(DeleteBehavior.Cascade);

		// One-to-many relationship with WorkPosition
		builder.HasOne(e => e.WorkPosition)
			.WithMany(w => w.Experiences)
			.HasForeignKey(e => e.ResumeId)
			.OnDelete(DeleteBehavior.Cascade);

		// Validation rules
		builder.Property(e => e.CompanyName)
			.IsRequired()
			.HasMaxLength(200);

		builder.Property(e => e.StartDate)
			.IsRequired()
			.HasColumnType("datetime2");

		builder.Property(e => e.EndDate)
			.IsRequired(false)
			.HasColumnType("datetime2");

		builder.Property(e => e.WorkType)
			.HasConversion(w => (int)w,w => (WorkTypes)w)
			.HasColumnType("int")
			.IsRequired();
	}
}