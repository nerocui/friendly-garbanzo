using Microsoft.AspNetCore.Identity;

namespace EIAU.Server.Models;

public class ApplicationUser : IdentityUser
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Handle { get; set; }
    public string ID { get; set; }
    public string AvatarUrl { get; set; }
    public ICollection<ApplicationUser> Followers { get; set; }
    public ICollection<ApplicationUser> Following { get; set; }
    public ICollection<ApplicationUser> Blocked { get; set; }
    public ICollection<ApplicationUser> Friends { get; set; }
}
