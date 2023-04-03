using HumanResourceManagementSystem.Domain.Entities;
using HumanResourceManagementSystem.Domain.Entities.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HumanResourceManagementSystem.Persistence.Configurations;

public class UserConfiguration : IEntityTypeConfiguration<User>
{
	public void Configure(EntityTypeBuilder<User> builder)
	{
		// Primary Key
		builder.HasKey(u => u.Id);

		// Relationships
		builder.HasOne(u => u.Resume)
			.WithOne(r => r.User)
			.HasForeignKey<Resume>(r => r.UserId)
			.OnDelete(DeleteBehavior.Cascade);

		builder.HasMany(u => u.Advertisements)
			.WithOne(a => a.User)
			.HasForeignKey(a => a.CreatedBy)
			.OnDelete(DeleteBehavior.Cascade);

		
		// Validation rules
		// Identity kütüphanesinden gelen sınıfın validation'u burada değil.
	}
}
