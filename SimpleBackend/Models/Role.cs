using Microsoft.AspNet.Identity.EntityFramework;

namespace SimpleBackend.Models
{
    public class Role : IdentityRole<int, UserRole>
    {
        public Role() { }
        public Role(string name) { base.Name = name; }
    }
}