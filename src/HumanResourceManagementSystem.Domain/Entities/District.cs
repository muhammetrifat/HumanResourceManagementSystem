namespace HumanResourceManagementSystem.Domain.Entities;

/// <summary>
/// İlçe bilgilerini tutan entity sınıfıdır.
/// </summary>
public sealed class District : BaseAuditableEntity
{
	public string Name { get; set; } = null!; // İlçe adı


	// City ile olan ilişkisi (1-1)
	// 1 İlçe'nin 1 tane Şehir'i olacak
	public Guid CityId { get; set; }
	public City City { get; set; } = null!;


	// Address ile olan ilişkisi (1-n)
	// 1 İlçe'nin N tane Adres'i olacak
	public ICollection<Address>? Addresses { get; set; }

}
