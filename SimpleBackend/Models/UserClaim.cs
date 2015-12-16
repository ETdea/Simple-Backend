using Microsoft.AspNet.Identity.EntityFramework;

namespace SimpleBackend.Models
{
    public class UserClaim : IdentityUserClaim<int>
    {
        public virtual User User { get; set; }
    }
}