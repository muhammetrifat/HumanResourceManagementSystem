namespace HumanResourceManagementSystem.Domain.Entities;

/// <summary>
/// Yetenek bilgilerinin tutulduğu entity sınıfıdır.
/// </summary>
public sealed class Skill : BaseAuditableEntity
{
	public string Name { get; set; } = null!; // Yetenek Adı


	// Resume ile olan ilişkisi (1-n)
	// 1 Özgeçmiş'in N tane Yetenek'i olacak
	public Guid ResumeId { get; set; }
	public Resume Resume { get; set; } = null!;

}
