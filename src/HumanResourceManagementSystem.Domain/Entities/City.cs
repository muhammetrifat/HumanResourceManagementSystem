namespace HumanResourceManagementSystem.Domain.Entities;

/// <summary>
/// Şehir bilgilerini tutan entity sınıfıdır.
/// </summary>
public sealed class City : BaseAuditableEntity
{
	public string Name { get; set; } = null!;
	public Guid CountryId { get; set; }
	public ICollection<District> Districts { get; set; } = null!;
    public Country Country { get; set; } = null!;
}
