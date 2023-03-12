using HumanResourceManagementSystem.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HumanResourceManagementSystem.Persistence.Configurations;

public class ResumeConfiguration : IEntityTypeConfiguration<Resume>
{
	public void Configure(EntityTypeBuilder<Resume> builder)
	{
		throw new NotImplementedException();
	}
}


