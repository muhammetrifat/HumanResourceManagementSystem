namespace HumanResourceManagementSystem.Domain.Entities;

/// <summary>
/// Eğitim bilgilerini tutan entity sınıfıdır.
/// </summary>
public sealed class Education : BaseAuditableEntity
{
	public Guid ResumeId { get; set; }
	public Resume Resume { get; set; } = null!;
	public string Name { get; set; } = null!;
	public string SectionName { get; set; } = null!;
	public DateTime StartDate { get; set; }
	public DateTime? EndDate { get; set; }
	public decimal GradeAverage { get; set; }
	public bool Status { get; set; }
}
