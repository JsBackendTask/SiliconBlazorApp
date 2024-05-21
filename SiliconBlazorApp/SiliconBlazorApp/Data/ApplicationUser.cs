using Microsoft.AspNetCore.Identity;

namespace SiliconBlazorApp.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        [ProtectedPersonalData]
        public string FirstName { get; set; } = null!;

        [ProtectedPersonalData]
        public string LastName { get; set; } = null!;
        public string? Bio { get; set; }
        public byte[]? ProfileImage { get; set; }

        public string? AddressId { get; set; }
        public AddressEntity? Address { get; set; }
    }

}
