namespace HumanResourceManagementSystem.Domain.Entities;

/// <summary>
/// Çalışma pozisyonlarını tutan entity sınıfıdır.
/// </summary>
public sealed class WorkPosition : BaseAuditableEntity
{
	public string Name { get; set; } = null!; // Çalışma pozisyonu adı

	// Experience ile olan ilişkisi (1-n)
	// 1 Çalışma Pozisyon'unun n tane Deneyimi olacak
	public ICollection<Experience> Experiences { get; set; } = null!;

}
