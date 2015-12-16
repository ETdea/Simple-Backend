using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin;
using SimpleBackend.Models;
using SimpleBackend.Stores;

namespace SimpleBackend.Managers
{
    // Configure the RoleManager used in the application. RoleManager is defined in the ASP.NET Identity core assembly
    public class RoleManager : RoleManager<Role, int>
    {
        public RoleManager(IRoleStore<Role, int> roleStore)
            : base(roleStore)
        {
        }

        public static RoleManager Create(IdentityFactoryOptions<RoleManager> options, IOwinContext context)
        {
            return new RoleManager(new RoleStore(context.Get<MyDbContext>()));
        }
    }
}