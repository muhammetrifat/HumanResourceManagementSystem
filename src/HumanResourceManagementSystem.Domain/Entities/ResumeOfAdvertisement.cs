using HumanResourceManagementSystem.Domain.Entities.Identity;

namespace HumanResourceManagementSystem.Domain.Entities;

/// <summary>
/// Başvuruda gönderilen özgeçmiş'lerin tutulduğu entity sınıfıdır.
/// </summary>
public sealed class ResumeOfAdvertisement : BaseAuditableEntity
{
	public Guid AdvertisementId { get; set; }
	public Advertisement Advertisement { get; set; } = null!;
	public Guid CompanyId { get; set; }
	public Company Company { get; set; } = null!;
	public Guid ResumeId { get; set; }
	public Resume Resume { get; set; } = null!;
	public Guid? ResumeCvId { get; set; }
	public Resume? ResumeCv { get; set; }
	public long UserId { get; set; }
	public User User { get; set; } = null!;

}
