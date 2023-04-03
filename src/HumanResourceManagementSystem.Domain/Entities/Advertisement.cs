using HumanResourceManagementSystem.Domain.Entities.Identity;
using HumanResourceManagementSystem.Domain.Enums;

namespace HumanResourceManagementSystem.Domain.Entities;

/// <summary>
/// İlan bilgilerini tutan entity sınıfıdır.
/// </summary>
public sealed class Advertisement : BaseAuditableEntity
{
    public decimal ExperienceStart { get; set; } // İş tecrübesi başlangıç yıl miktarı. 1,5 sene
	public decimal ExperienceEnd { get; set; } // İş tecrübesi bitiş yıl miktarı. 2,5 sene
	public string Description { get; set; } = null!; // İlan açıklaması.
	public bool IsCvRequired { get; set; } // CV gerekli mi?
	public WorkTypes WorkType { get; set; } // İş tipi.


	// Company ile olan ilişkisi (1-n)
	// 1 Şirket'in n tane İlan'ı olacak
	public Guid CompanyId { get; set; }
    public Company Company { get; set; } = null!;


	// Department ile olan ilişkisi (1-n)
	// 1 Departman'ın N tane İlan'ı olacak
	public Guid DepartmentId { get; set; }
    public Department Department { get; set; } = null!;


	// JobApplication ile olan ilişkisi (1-n)
	// 1 İlan'ın N tane iş başvurusu olacak
	public ICollection<JobApplication>? JobApplications { get; set; }

	// 1 Kullanıcı'nın N tane İlanı olacak (İlanı yayınlayan kullanıcılar kast ediliyor)
	// UserId alanı miras alınan BaseAuditibleEntity sınıfındaki CreatedBy property'sidir.
	public User User { get; set; } = null!;

}