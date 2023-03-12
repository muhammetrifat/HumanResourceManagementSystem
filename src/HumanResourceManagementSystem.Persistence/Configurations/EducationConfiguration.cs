using HumanResourceManagementSystem.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HumanResourceManagementSystem.Persistence.Configurations;

public class EducationConfiguration : IEntityTypeConfiguration<Education>
{
	public void Configure(EntityTypeBuilder<Education> builder)
	{
		throw new NotImplementedException();
	}
}


