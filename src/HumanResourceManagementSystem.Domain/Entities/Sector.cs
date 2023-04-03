namespace HumanResourceManagementSystem.Domain.Entities;

/// <summary>
/// Sektörlerin tutulduğu entity sınıfıdır.
/// </summary>
public sealed class Sector : BaseAuditableEntity
{
	public string Name { get; set; } = null!; // Sektör adı

	// Company ile olan ilişkisi (1-n)
	// 1 Sektörün N tane Firma'sı olacak
	public ICollection<SectorsOfCompanies>? SectorsOfCompanies { get; set; }

	// Experience ile olan ilişkisi (1-n)
	// 1 Sektörün N tane Deneyim'i olacak
	public ICollection<Experience>? Experiences { get; set; }

}
