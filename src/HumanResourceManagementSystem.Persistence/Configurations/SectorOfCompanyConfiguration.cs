using HumanResourceManagementSystem.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HumanResourceManagementSystem.Persistence.Configurations;

public class SectorOfCompanyConfiguration : IEntityTypeConfiguration<SectorOfCompany>
{
	public void Configure(EntityTypeBuilder<SectorOfCompany> builder)
	{
		throw new NotImplementedException();
	}
}


