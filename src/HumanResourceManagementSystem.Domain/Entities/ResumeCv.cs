using HumanResourceManagementSystem.Domain.Entities.Identity;

namespace HumanResourceManagementSystem.Domain.Entities;

/// <summary>
/// CV'lerin tutulduğu entity sınıfıdır.
/// </summary>
public sealed class ResumeCv : BaseAuditableEntity
{
	public long UserId { get; set; }
	public User User { get; set; } = null!;
	public string FileName { get; set; } = null!;
	public string FileExtension { get; set; } = null!;
	public string File { get; set; } = null!;

}
