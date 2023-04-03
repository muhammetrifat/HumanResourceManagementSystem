using HumanResourceManagementSystem.Domain.Entities.Identity;

namespace HumanResourceManagementSystem.Domain.Entities;

/// <summary>
/// CV'lerin tutulduğu entity sınıfıdır.
/// </summary>
public sealed class ResumeCv : BaseAuditableEntity
{
	public string FileName { get; set; } = null!; // Dosya ismi
	public string FileExtension { get; set; } = null!; // Dosya uzantısı
	public byte[] File { get; set; } = null!; // Dosya (Base64)


	// Resume ile olan ilişkisi (1-1)
	// 1 CV'nin 1 tane Özgeçmiş'i olacak
	public Guid ResumeId { get; set; }
	public Resume Resume { get; set; } = null!;

	// JobApplication ile olan ilişkisi (1-n)
	// 1 CV'nin N tane İş Başvuru'su olacak
	public ICollection<JobApplication> JobApplications { get; set; } = null!;
}
