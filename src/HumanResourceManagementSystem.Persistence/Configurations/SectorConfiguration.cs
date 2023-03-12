using HumanResourceManagementSystem.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HumanResourceManagementSystem.Persistence.Configurations;

public class SectorConfiguration : IEntityTypeConfiguration<Sector>
{
	public void Configure(EntityTypeBuilder<Sector> builder)
	{
		throw new NotImplementedException();
	}
}


