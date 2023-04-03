using HumanResourceManagementSystem.Domain.Entities.Identity;

namespace HumanResourceManagementSystem.Domain.Entities;

/// <summary>
/// İş başvurularının tutulduğu entity sınıfıdır.
/// </summary>
public sealed class JobApplication : BaseAuditableEntity
{
	// Advertisement ile olan ilişkisi (1-1)
	// 1 İş başvurusu'nun 1 tane Şirket'i olacak
	public Guid AdvertisementId { get; set; }
	public Advertisement Advertisement { get; set; } = null!;


	// Company ile olan ilişkisi (1-1)
	// 1 İş başvurusu'nun 1 tane Şirket'i olacak
	public Guid CompanyId { get; set; }
	public Company Company { get; set; } = null!;


	// Resume ile olan ilişkisi (1-1)
	// 1 İş başvurusu'nun 1 tane Özgeçmiş'i olacak
	public Guid ResumeId { get; set; }
	public Resume Resume { get; set; } = null!;


	// ResumeCv ile olan ilişkisi (1-n)
	// 1 Cv'nin N tane İş Başvuru'su olacak
	public Guid? ResumeCvId { get; set; }
	public ResumeCv? ResumeCv { get; set; }
}
