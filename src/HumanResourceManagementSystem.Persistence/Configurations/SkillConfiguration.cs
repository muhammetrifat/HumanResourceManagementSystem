using HumanResourceManagementSystem.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HumanResourceManagementSystem.Persistence.Configurations;

public class SkillConfiguration : IEntityTypeConfiguration<Skill>
{
	public void Configure(EntityTypeBuilder<Skill> builder)
	{
		throw new NotImplementedException();
	}
}


