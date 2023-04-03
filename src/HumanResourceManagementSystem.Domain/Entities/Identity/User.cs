using Microsoft.AspNetCore.Identity;

namespace HumanResourceManagementSystem.Domain.Entities.Identity;

/// <summary>
/// Kullanıcı bilgilerinin tutulduğu entity sınıfıdır.
/// Barınacak kullanıcıların tipleri: İnsan Kaynakları Yetkilisi, İş Arayan Kullanıcı
/// </summary>
public class User : IdentityUser<long>
{
	public bool IsHumanResourceOfCompany { get; set; } // Kullanıcı insan kaynakları yetkilisi mi?

	// Ceo kullanıcılarının firma bilgisi düzenleyebilmesi için bunu ekledik
    public bool IsCeoOfCompany { get; set; } // Kullanıcı şirket müdürü mü?


	// Resume ile olan ilişkisi (1-1)
	// 1 Kullanıcı'nın 1 tane Özgeçmiş'i olacak
	public Guid? ResumeId { get; set; }
    public Resume? Resume { get; set; }


	// Company ile olan ilişkisi (1-1)
	// 1 Kullanıcı'nın 1 tane Şirket'i olacak
	public Guid? CompanyId { get; set; }
	public Company? Company { get; set; }


	// Advertisement ile olan ilişkisi (1-n)
	// 1 Kullanıcı'nın N tane İlanı olacak (İlanı yayınlayan kullanıcılar kast ediliyor)
	public ICollection<Advertisement>? Advertisements { get; set; }


	// JobApplication ile olan ilişkisi (1-n)
	// 1 Kullanıcı'nın N tane iş başvurusu olacak (İlana başvuran kullanıcılar kast ediliyor)
	public ICollection<JobApplication>? JobApplications { get; set; }
}