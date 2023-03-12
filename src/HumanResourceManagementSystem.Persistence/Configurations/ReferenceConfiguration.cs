using HumanResourceManagementSystem.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HumanResourceManagementSystem.Persistence.Configurations;

public class ReferenceConfiguration : IEntityTypeConfiguration<Reference>
{
	public void Configure(EntityTypeBuilder<Reference> builder)
	{
		throw new NotImplementedException();
	}
}


