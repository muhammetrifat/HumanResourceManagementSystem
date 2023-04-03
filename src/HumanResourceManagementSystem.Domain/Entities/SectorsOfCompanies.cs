namespace HumanResourceManagementSystem.Domain.Entities;

public class SectorsOfCompanies : BaseAuditableEntity
{
    public Guid CompanyId { get; set; }
    public Company Company { get; set; } = null!;
	public Guid SectorId { get; set; }
    public Sector Sector { get; set; } = null!;
}
