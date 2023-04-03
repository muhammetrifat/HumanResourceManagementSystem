using HumanResourceManagementSystem.Domain.Entities.Identity;

namespace HumanResourceManagementSystem.Domain.Entities;

/// <summary>
/// Özgeçmiş bilgilerini tutan entity sınıfıdır.
/// </summary>
public sealed class Resume : BaseAuditableEntity
{
	// Skill ile olan ilişkisi (1-n)
	// 1 Özgeçmiş'in N tane Yetenek'i olacak
	public ICollection<Skill>? Skills { get; set; }


	// Language ile olan ilişkisi (1-n)
	// 1 Özgeçmiş'in N tane Yabancı Dil'i olacak
	public ICollection<Language>? Languages { get; set; }


	// Project ile olan ilişkisi (1-n)
	// 1 Özgeçmiş'in N tane Proje'si olacak
	public ICollection<Project>? Projects { get; set; }


	// Profile ile olan ilişkisi (1-1)
	// 1 Özgeçmiş'in 1 tane Profil'i olacak
	public Guid? ProfileId { get; set; }
	public Profile? Profile { get; set; }


	// Experience ile olan ilişkisi (1-n)
	// 1 Özgeçmiş'in N tane Deneyim'i olacak
	public ICollection<Experience>? Experiences { get; set; }


	// Reference ile olan ilişkisi (1-n)
	// 1 Özgeçmiş'in N tane Referans'ı olacak
	public ICollection<Reference>? References { get; set; }


	// Education ile olan ilişkisi (1-n)
	// 1 Özgeçmiş'in N tane Eğitim Bilgi'si olacak
	public ICollection<Education>? Educations { get; set; }


	// Certificate ile olan ilişkisi (1-n)
	// 1 Özgeçmiş'in N tane Sertifika'sı olacak
	public ICollection<Certificate>? Certificates { get; set; }


	// User ile olan ilişkisi (1-1)
	// 1 Özgeçmiş'in 1 tane Kullanıcı'sı olacak
	public long UserId { get; set; }
	public User User { get; set; } = null!;


	// Address ile olan ilişkisi (1-1)
	// 1 Özgeçmiş'in 1 tane Adres'i olacak
	public Guid? AddressId { get; set; }
	public Address? Address { get; set; }


	// JobApplication ile olan ilişkisi (1-n)
	// 1 Özgeçmiş'in N tane İş Başvurusu'su olacak
	public ICollection<JobApplication>? JobApplications { get; set; }

	// ResumeCv ile olan ilişkisi (1-1)
	// 1 Özgemiş'in 1 tane CV'si olacak
	public Guid? ResumeCvId { get; set; }
	public ResumeCv? ResumeCv { get; set; }
}
