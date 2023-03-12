namespace HumanResourceManagementSystem.Domain.Entities;

/// <summary>
/// İlçe bilgilerini tutan entity sınıfıdır.
/// </summary>
public sealed class District : BaseAuditableEntity
{
	public string Name { get; set; } = null!;
	public Guid CityId { get; set; }
	public City City { get; set; } = null!;
}
