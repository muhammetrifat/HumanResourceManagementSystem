using HumanResourceManagementSystem.Domain.Enums;

namespace HumanResourceManagementSystem.Domain.Entities;

/// <summary>
/// Yabancı Dil Bilgilerini tutan entity sınıfıdır.
/// </summary>
public sealed class Language : BaseAuditableEntity
{
	public string Name { get; set; } = null!; // Dil adı
	public LanguageLevels Level { get; set; } // Dil seviyesi


	// Resume ile olan ilişkisi (1-n)
	// 1 Yabancı Dil'in 1 tane Özgeçmiş'i olacak
	public Guid ResumeId { get; set; }
	public Resume Resume { get; set; } = null!;
}
