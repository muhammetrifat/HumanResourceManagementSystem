using Microsoft.AspNetCore.Identity;

namespace HumanResourceManagementSystem.Domain.Entities.Identity;

/// <summary>
/// User rollerinin tutulduğu entity sınıfıdır.
/// </summary>
public class Role : IdentityRole<long>
{
}