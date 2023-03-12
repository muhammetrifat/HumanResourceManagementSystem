namespace HumanResourceManagementSystem.Domain.Entities;

/// <summary>
/// Referans bilgilerini tutan entity sınıfıdır.
/// </summary>
public sealed class Reference : BaseAuditableEntity
{
	public Guid ResumeId { get; set; }
	public Resume Resume { get; set; } = null!;
	public string FirstName { get; set; } = null!;
	public string LastName { get; set; } = null!;
	public string FullName => $"{FirstName} {LastName}";
	public string Email { get; set; } = null!;
	public string Phone { get; set; } = null!;
	public string CompanyName { get; set; } = null!;
	public string PositionName { get; set; } = null!;
}
