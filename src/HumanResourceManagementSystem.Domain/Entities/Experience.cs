using HumanResourceManagementSystem.Domain.Enums;

namespace HumanResourceManagementSystem.Domain.Entities;

/// <summary>
/// Deneyim bilgilerini tutan entity sınıfıdır.
/// </summary>
public sealed class Experience : BaseAuditableEntity
{
	public Guid ResumeId { get; set; }
	public Resume Resume { get; set; } = null!;
	public string CompanyName { get; set; } = null!;
	public Guid SectorId{ get; set; }
	public Sector Sector { get; set; } = null!;
	public DateTime StartDate { get; set; }
	public DateTime? EndDate { get; set; }
	public Guid WorkPositionId { get; set; }
	public WorkPosition WorkPosition { get; set; } = null!;
	public WorkTypes WorkType { get; set; }
}
