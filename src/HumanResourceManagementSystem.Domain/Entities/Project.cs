namespace HumanResourceManagementSystem.Domain.Entities;

/// <summary>
/// Projeleri tutan entity sınıfıdır.
/// </summary>
public sealed class Project : BaseAuditableEntity
{
	public Guid ResumeId { get; set; }
	public Resume Resume { get; set; } = null!;
	public string Name { get; set; } = null!;
	public string Description { get; set; } = null!;
	public DateTime StartDate { get; set; }
	public DateTime? FinishDate { get; set; }
	public string? Url { get; set; }

}
