using Microsoft.AspNetCore.Identity;

namespace Mango_Fusion_API.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; } = string.Empty;
    }
}
