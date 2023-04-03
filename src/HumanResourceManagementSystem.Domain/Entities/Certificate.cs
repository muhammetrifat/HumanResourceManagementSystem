namespace HumanResourceManagementSystem.Domain.Entities;

/// <summary>
/// Sertifika bilgilerini tutan entity sınıfıdır.
/// </summary>
public sealed class Certificate : BaseAuditableEntity
{
	public string Name { get; set; } = null!; // Sertifika adı
	public string OrganizationName { get; set; } = null!; // Sertifika alınan organizasyonun adı
	public DateTime StartDate { get; set; } // Başlangıç tarihi
	public DateTime EndDate { get; set; } // Bitiş tarihi
	public bool IsTemporary{ get; set; } // Geçici mi?


	// Resume ile olan ilişkisi (1-n)
	// 1 Özgeçmiş'in N tane Sertifika'sı olacak
	public Guid ResumeId { get; set; }
	public Resume Resume { get; set; } = null!;
}
