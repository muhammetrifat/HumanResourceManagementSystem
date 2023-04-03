using HumanResourceManagementSystem.Domain.Entities.Identity;

namespace HumanResourceManagementSystem.Domain.Entities;

/// <summary>
/// Firma bilgilerini tutan entity sınıfıdır.
/// </summary>
public sealed class Company : BaseAuditableEntity
{
    public string Name { get; set; } = null!; // Şirket adı
	public string About { get; set; } = null!; // Hakkında
	public int NumberOfEmployees { get; set; } // Çalışan sayısı
	public string? Benefits { get; set; } // Yan haklar
	public string? WebSiteUrl { get; set; } // Web sitesi adresi
	public string TaxNumber { get; set; } = null!; // Vergi numarası


	// Address ile olan ilişkisi (1-1)
	// 1 Firma'nın 1 tane Adres'i olacak
	public Guid AddressId { get; set; }
	public Address Address { get; set; } = null!;


	// User ile olan ilişkisi (1-n)
	// 1 Firma'nın N tane Kullanıcı'sı olacak
	public ICollection<User> Users { get; set; } = null!;


	// Advertisement ile olan ilişkisi (1-n)
	// 1 Firma'nın N tane İlan'ı olacak
	public ICollection<Advertisement>? Advertisements { get; set; }

	// Sector ile olan ilişkisi (n-n)
	// N Firma'nın N tane Sektör'ü olacak
	public ICollection<SectorsOfCompanies>? SectorsOfCompanies { get; set; }

	// JobApplication ile olan ilişkisi (1-n)
	// 1 Firma'nın N tane İş Başvurusu Kayıt'ı olacak
	public ICollection<JobApplication>? JobApplications { get; set; }
}
