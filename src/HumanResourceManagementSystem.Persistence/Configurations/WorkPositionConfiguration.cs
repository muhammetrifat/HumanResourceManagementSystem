using HumanResourceManagementSystem.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HumanResourceManagementSystem.Persistence.Configurations;

public class WorkPositionConfiguration : IEntityTypeConfiguration<WorkPosition>
{
	public void Configure(EntityTypeBuilder<WorkPosition> builder)
	{
		throw new NotImplementedException();
	}
}


