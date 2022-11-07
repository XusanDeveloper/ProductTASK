using Microsoft.AspNetCore.Identity;

namespace ProductTASK.Models
{
    public class ApplicationUser : IdentityUser
    {
        public ApplicationUser() : base() { }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
