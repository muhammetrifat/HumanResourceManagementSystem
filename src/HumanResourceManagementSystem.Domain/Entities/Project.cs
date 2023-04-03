namespace HumanResourceManagementSystem.Domain.Entities;

/// <summary>
/// Projeleri tutan entity sınıfıdır.
/// </summary>
public sealed class Project : BaseAuditableEntity
{
	public string Name { get; set; } = null!; // Proje adı
	public string Description { get; set; } = null!; // Proje açıklaması
	public DateTime StartDate { get; set; } // Proje başlangıç tarihi
	public DateTime? EndDate { get; set; } // Proje bitiş tarihi
	public string? Url { get; set; } // Proje URL


	// Resume ile olan ilişkisi (1-n)
	// 1 Özgeçmiş'in N tane Proje'si olacak
	public Guid ResumeId { get; set; }
	public Resume Resume { get; set; } = null!;

}
