namespace HumanResourceManagementSystem.Domain.Entities;

/// <summary>
/// Ülke bilgilerini tutan entity sınıfıdır.
/// </summary>
public sealed class Country : BaseAuditableEntity
{
	public string Name { get; set; } = null!; // Ülke adı
	public string Code { get; set; } = null!; // Ülke kodu (TR, EN)


	// City ile olan ilişkisi (1-n)
	// 1 Ülke'nin N tane Şehir'i olacak
	public ICollection<City> Cities { get; set; } = null!;


	// Address ile olan ilişkisi (1-n)
	// 1 Ülke'nin N tane Adres'i olacak
	public ICollection<Address>? Addresses { get; set; }
}
