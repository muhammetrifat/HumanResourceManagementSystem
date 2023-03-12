namespace HumanResourceManagementSystem.Domain.Entities;

/// <summary>
/// Departman bilgilerini tutan entity sınıfıdır.
/// </summary>
public sealed class Department : BaseAuditableEntity
{
    public string Name { get; set; } = null!;
    public string Description { get; set; } = null!;
}