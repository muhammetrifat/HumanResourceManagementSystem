namespace HumanResourceManagementSystem.Domain.Entities;

/// <summary>
/// Ülke bilgilerini tutan entity sınıfıdır.
/// </summary>
public sealed class Country : BaseAuditableEntity
{
	public string Name { get; set; } = null!;
	public string Code { get; set; } = null!;
    public ICollection<City> Cities { get; set; } = null!;
}
