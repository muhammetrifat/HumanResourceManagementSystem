namespace HumanResourceManagementSystem.Domain.Entities;

/// <summary>
/// Referans bilgilerini tutan entity sınıfıdır.
/// </summary>
public sealed class Reference : BaseAuditableEntity
{
	public string FirstName { get; set; } = null!; // İsim
	public string LastName { get; set; } = null!; // Soyisim
	public string FullName => $"{FirstName} {LastName}"; // Tam isim
	public string Email { get; set; } = null!; // Email
	public string Phone { get; set; } = null!; // Telefon
	public string CompanyName { get; set; } = null!; // Şirket adı
	public string PositionName { get; set; } = null!; // Pozisyon adı


	// Resume ile olan ilişkisi (1-n)
	// 1 Özgeçmiş'in N tane Referans'ı olacak
	public Guid ResumeId { get; set; }
	public Resume Resume { get; set; } = null!;
}
