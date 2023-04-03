using HumanResourceManagementSystem.Domain.Entities.Identity;

namespace HumanResourceManagementSystem.Domain.Entities;

/// <summary>
/// Adres bilgilerini tutan entity sınıfıdır.
/// </summary>
public sealed class Address : BaseAuditableEntity
{
	public string Description { get; set; } = null!; // Adres açıklaması
	public bool IsUser { get; set; } // Adres bir kullanıcıya ait mi?
	public bool IsCompany { get; set; } // Adres bir şirkete ait mi?


	// Country ile olan ilişkisi (1-n)
	// 1 Ülke'nin N tane Adres'i olacak
	public Guid CountryId { get; set; }
    public Country Country { get; set; } = null!;


	// City ile olan ilişkisi (1-n)
	// 1 Şehir'in N tane Adres'i olacak
	public Guid CityId { get; set; }
	public City City { get; set; } = null!;


	// District ile olan ilişkisi (1-n)
	// 1 İlçe'nin N tane Adres'i olacak
	public Guid DistrictId { get; set; }
	public District District { get; set; } = null!;


	// Resume ile olan ilişkisi (1-1)
	// 1 Adres'in 1 tane Özgeçmiş'i olacak (Eğer IsUser true olursa bu alan dolacaktır)
	public Guid? ResumeId { get; set; }
	public Resume? Resume { get; set; }


	// Company ile olan ilişkisi (1-1)
	// 1 Adres'in 1 tane Şirket'i olacak (Eğer IsCompany true olursa bu alan dolacaktır)
	public Guid? CompanyId { get; set; }
	public Company? Company { get; set; }

    

}
