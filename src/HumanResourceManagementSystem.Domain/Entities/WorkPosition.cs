namespace HumanResourceManagementSystem.Domain.Entities;

/// <summary>
/// Çalışma pozisyonlarını tutan entity sınıfıdır.
/// </summary>
public sealed class WorkPosition : BaseAuditableEntity
{
	public string Name { get; set; } = null!;

}
