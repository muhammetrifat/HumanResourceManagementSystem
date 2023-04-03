namespace HumanResourceManagementSystem.Domain.Entities;

/// <summary>
/// Departman bilgilerini tutan entity sınıfıdır.
/// </summary>
public sealed class Department : BaseAuditableEntity
{
    public string Name { get; set; } = null!; // Departman adı
    public string Description { get; set; } = null!; // Departman açıklaması


	// Advertisement ile olan ilişkisi (1-n)
	// 1 Departman'ın N tane İlan'ı olacak
	public ICollection<Advertisement>? Advertisements { get; set; }
}