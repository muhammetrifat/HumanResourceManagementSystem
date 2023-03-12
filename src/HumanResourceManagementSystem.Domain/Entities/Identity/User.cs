using Microsoft.AspNetCore.Identity;

namespace HumanResourceManagementSystem.Domain.Entities.Identity;

/// <summary>
/// User bilgilerinin tutulduğu entity sınıfıdır.
/// </summary>
public class User : IdentityUser<long>
{
    public Guid? CompanyId { get; set; }
    public Company? Company { get; set; }
    public bool IsCeoOfCompany { get; set; }
    public bool IsHumanResourceOfCompany { get; set; }
}