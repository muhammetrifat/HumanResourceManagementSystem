namespace HumanResourceManagementSystem.Domain.Entities;

/// <summary>
/// Sertifika bilgilerini tutan entity sınıfıdır.
/// </summary>
public sealed class Certificate : BaseAuditableEntity
{
	public Guid ResumeId { get; set; }
	public Resume Resume { get; set; } = null!;
	public string Name { get; set; } = null!;
	public string OrganizationName { get; set; } = null!;
	public DateTime StartDate { get; set; }
	public DateTime EndDate { get; set; }
	public bool IsTemporary{ get; set; }
}
