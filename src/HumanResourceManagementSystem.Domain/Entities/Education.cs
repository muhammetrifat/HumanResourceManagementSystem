namespace HumanResourceManagementSystem.Domain.Entities;

/// <summary>
/// Eğitim bilgilerini tutan entity sınıfıdır.
/// </summary>
public sealed class Education : BaseAuditableEntity
{
	public string Name { get; set; } = null!; // Okul adı
	public string SectionName { get; set; } = null!; // Bölüm adı
	public DateTime StartDate { get; set; } // Başlangıç tarihi
	public DateTime? EndDate { get; set; } // Bitiş tarihi
	public decimal GradeAverage { get; set; } // Not ortalaması
	public bool Status { get; set; } // Eğitim durumu


	// Resume ile olan ilişkisi (1-n)
	// 1 Özgeçmiş'in N tane Eğitim Bilgisi olacak
	public Guid ResumeId { get; set; }
	public Resume Resume { get; set; } = null!;
}
