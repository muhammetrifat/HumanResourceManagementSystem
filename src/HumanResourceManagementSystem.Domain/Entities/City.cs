namespace HumanResourceManagementSystem.Domain.Entities;

/// <summary>
/// Şehir bilgilerini tutan entity sınıfıdır.
/// </summary>
public sealed class City : BaseAuditableEntity
{
	public string Name { get; set; } = null!; // Şehir adı


	// Country ile olan ilişkisi (1-n)
	// 1 Ülke'nin N tane Şehir'i olacak
	public Guid CountryId { get; set; }
	public Country Country { get; set; } = null!;


	// District ile olan ilişkisi (1-n)
	// 1 Şehir'in N tane İlçe'si olacak
	public ICollection<District> Districts { get; set; } = null!;


	// Address ile olan ilişkisi (1-n)
	// 1 Şehir'in N tane Adres'i olacak
	public ICollection<Address>? Addresses { get; set; }

}
