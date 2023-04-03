using HumanResourceManagementSystem.Domain.Enums;

namespace HumanResourceManagementSystem.Domain.Entities;

/// <summary>
/// Deneyim bilgilerini tutan entity sınıfıdır.
/// </summary>
public sealed class Experience : BaseAuditableEntity
{
	public string CompanyName { get; set; } = null!; // Şirket adı
	public DateTime StartDate { get; set; } // Başlangıç tarihi
	public DateTime? EndDate { get; set; } // Bitiş tarihi
	public WorkTypes WorkType { get; set; } // İş türü


	// WorkPosition ile olan ilişkisi (1-1)
	// 1 Deneyim'in 1 tane Çalışma Pozisyon'u olacak
	public Guid WorkPositionId { get; set; }
	public WorkPosition WorkPosition { get; set; } = null!;


	// Sector ile olan ilişkisi (1-1)
	// 1 Deneyim'in 1 tane Sektör'ü olacak
	public Guid SectorId{ get; set; }
	public Sector Sector { get; set; } = null!;


	// Resume ile olan ilişkisi (1-n)
	// 1 Deneyim'in 1 tane Özgeçmiş'i olacak
	public Guid ResumeId { get; set; }
	public Resume Resume { get; set; } = null!;
}
