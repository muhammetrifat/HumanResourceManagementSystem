using HumanResourceManagementSystem.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HumanResourceManagementSystem.Persistence.Configurations;

public class LanguageConfiguration : IEntityTypeConfiguration<Language>
{
	public void Configure(EntityTypeBuilder<Language> builder)
	{
		throw new NotImplementedException();
	}
}


