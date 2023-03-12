using HumanResourceManagementSystem.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HumanResourceManagementSystem.Persistence.Configurations;

public class CityConfiguration : IEntityTypeConfiguration<City>
{
	public void Configure(EntityTypeBuilder<City> builder)
	{
		builder.HasOne(s => s.Country)
			.WithMany(g => g.Cities)
			.HasForeignKey(s => s.CountryId);

		builder.HasMany(x => x.Districts)
			.WithOne(x => x.City);
	}
}