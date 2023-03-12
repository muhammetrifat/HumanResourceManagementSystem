using HumanResourceManagementSystem.Domain.Entities.Identity;
using HumanResourceManagementSystem.Domain.Enums;

namespace HumanResourceManagementSystem.Domain.Entities;

/// <summary>
/// İlan bilgilerini tutan entity sınıfıdır.
/// </summary>
public sealed class Advertisement : BaseAuditableEntity
{
    public Guid CompanyId { get; set; }
    public Company Company { get; set; } = null!;
    public Guid DepartmentId { get; set; }
    public Department Department { get; set; } = null!;
    public long UserId { get; set; }
    public User User { get; set; } = null!;
    public decimal ExperienceStart { get; set; }
    public decimal ExperienceEnd { get; set; }
    public string Description { get; set; } = null!;
    public bool IsCvRequired { get; set; }
	public WorkTypes WorkType { get; set; }

}
