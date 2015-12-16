using Microsoft.AspNet.Identity.EntityFramework;

namespace SimpleBackend.Models
{
    public class UserLogin : IdentityUserLogin<int>
    {
        public virtual User User { get; set; }
    }
}