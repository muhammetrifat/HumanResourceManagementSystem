using HumanResourceManagementSystem.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HumanResourceManagementSystem.Persistence.Configurations;

public class DepartmentConfiguration : IEntityTypeConfiguration<Department>
{
    public void Configure(EntityTypeBuilder<Department> builder)
    {
        // Primary Key
        builder.HasKey(d => d.Id);

		// Relationships

        // One-to-many relationship with Advertisement
        builder.HasMany(d => d.Advertisements)
			.WithOne(a => a.Department)
			.HasForeignKey(d => d.DepartmentId)
			.OnDelete(DeleteBehavior.Cascade);

        // Validation rules

        builder.Property(d => d.Name)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(d => d.Description)
            .IsRequired()
			.HasMaxLength(500);


	}
}