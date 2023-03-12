using HumanResourceManagementSystem.Domain.Entities.Identity;

namespace HumanResourceManagementSystem.Domain.Entities;

/// <summary>
/// Adres bilgilerini tutan entity sınıfıdır.
/// </summary>
public sealed class Address : BaseAuditableEntity
{
	public string Description { get; set; } = null!;
	public long UserId { get; set; }
	public User User { get; set; } = null!;
	public Guid CountryId { get; set; }
	public Guid CityId { get; set; }
	public Guid DistrictId { get; set; }
}
