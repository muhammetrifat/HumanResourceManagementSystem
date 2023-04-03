using HumanResourceManagementSystem.Domain.Enums;

namespace HumanResourceManagementSystem.Domain.Entities;

/// <summary>
/// Profil bilgilerini tutan entity sınıfıdır.
/// </summary>
public sealed class Profile : BaseAuditableEntity
{
	public string FirstName { get; set; } = null!; // İsim
	public string LastName { get; set; } = null!; // Soyisim
	public string FullName => $"{FirstName} {LastName}"; // Tam isim
	public string? About { get; set; } // Hakkında
	public string Email { get; set; } = null!; // Email
	public int Age => DateTime.Now.Year - BirthDate.Year; // Yaş
	public Genders Gender { get; set; } // Cinsiyet
	public DateTime BirthDate { get; set; } // Doğum tarihi
	public string? WebSiteUrl { get; set; } // Web sitesi URL


	// Resume ile olan ilişkisi (1-1)
	// 1 Profil'in 1 tane Özgeçmiş'i olacak
	public Guid ResumeId { get; set; }
	public Resume Resume { get; set; } = null!;


}
