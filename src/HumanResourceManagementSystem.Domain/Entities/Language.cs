using HumanResourceManagementSystem.Domain.Enums;

namespace HumanResourceManagementSystem.Domain.Entities;

/// <summary>
/// Yabancı Dil Bilgilerini tutan entity sınıfıdır.
/// </summary>
public sealed class Language : BaseAuditableEntity
{
	public Guid ResumeId { get; set; }
	public Resume Resume { get; set; } = null!;
	public LanguageLevels Level { get; set; }
}
