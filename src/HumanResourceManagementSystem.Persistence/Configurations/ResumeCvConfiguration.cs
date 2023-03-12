using HumanResourceManagementSystem.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HumanResourceManagementSystem.Persistence.Configurations;

public class ResumeCvConfiguration : IEntityTypeConfiguration<ResumeCv>
{
	public void Configure(EntityTypeBuilder<ResumeCv> builder)
	{
		throw new NotImplementedException();
	}
}


