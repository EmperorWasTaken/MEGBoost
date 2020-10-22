using Microsoft.AspNetCore.Identity;

namespace MEG_Boosting_Site.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Nickname { get; set; }
    }
}