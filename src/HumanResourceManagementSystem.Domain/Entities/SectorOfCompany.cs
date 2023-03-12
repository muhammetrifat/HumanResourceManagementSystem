namespace HumanResourceManagementSystem.Domain.Entities;

/// <summary>
/// Firmaların sektörlerinin tutulduğu entity sınıfıdır.
/// </summary>
public sealed class SectorOfCompany : BaseAuditableEntity
{
	public Guid CompanyId { get; set; }
	public Company Company { get; set; } = null!;
	public Guid SectorId { get; set; }
	public Sector Sector { get; set; } = null!;
}
