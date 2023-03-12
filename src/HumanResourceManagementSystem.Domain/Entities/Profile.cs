using HumanResourceManagementSystem.Domain.Enums;

namespace HumanResourceManagementSystem.Domain.Entities;

/// <summary>
/// Profil bilgilerini tutan entity sınıfıdır.
/// </summary>
public sealed class Profile : BaseAuditableEntity
{
	public Guid ResumeId { get; set; }
	public Resume Resume { get; set; } = null!;
	public string FirstName { get; set; } = null!;
	public string LastName { get; set; } = null!;
	public string FullName => $"{FirstName} {LastName}";
	public string? About { get; set; }
	public string Email { get; set; } = null!;
	public DateTime BirthDate { get; set; }
	public int Age => DateTime.Now.Year - BirthDate.Year;
	public Genders Gender { get; set; }
	public string? WebSiteUrl { get; set; }


}
