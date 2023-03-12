namespace HumanResourceManagementSystem.Domain.Entities;

/// <summary>
/// Sektörlerin tutulduğu entity sınıfıdır.
/// </summary>
public sealed class Sector : BaseAuditableEntity
{
	public string Name { get; set; } = null!;

}
