using HumanResourceManagementSystem.Domain.Entities.Identity;

namespace HumanResourceManagementSystem.Domain.Entities;

/// <summary>
/// Firma bilgilerini tutan entity sınıfıdır.
/// </summary>
public sealed class Company : BaseAuditableEntity
{
    public string Name { get; set; } = null!;
	public string About { get; set; } = null!;
	public int NumberOfEmployees { get; set; }
	public string? Benefits { get; set; }
	public string? WebSiteUrl { get; set; }
	public Guid AddressId { get; set; }
	public Address Address { get; set; } = null!;
	public string TaxNumber { get; set; } = null!;
	public ICollection<User> Users { get; set; } = null!;
}
