namespace HumanResourceManagementSystem.Domain.Entities;

/// <summary>
/// Yetenek bilgilerinin tutulduğu entity sınıfıdır.
/// </summary>
public sealed class Skill : BaseAuditableEntity
{
	public Guid ResumeId { get; set; }
	public Resume Resume { get; set; } = null!;
	public string Name { get; set; } = null!;

}
