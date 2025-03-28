using Microsoft.AspNetCore.Identity;

namespace CVOnline.Web.Models.Domain
{
    public class ApplicationUser : IdentityUser
    {
        public string FullName { get; set; }
        public string? Address { get; set; }
        public new string? PhoneNumber { get; set; }
        public string? AvatarUrl { get; set; }
        public ICollection<CV> CVs { get; set; }
    }
}