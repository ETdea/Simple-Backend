using Microsoft.AspNet.Identity.Owin;
using SimpleBackend.Managers;
using SimpleBackend.Models;
using System.Web;

namespace SimpleBackend
{
    public class DatabaseConfig
    {
        internal static void RegisterDbContext()
        {
            DbInitializer.AddSeed(InitializeUser);
        }

        public static object InitializeUser()
        {
            const string name = "admin";
            const string password = "11111";

            var userManager = HttpContext.Current.GetOwinContext().GetUserManager<UserManager>();
            var user = new User { UserName = name, PhoneNumberConfirmed = true, Enabled = true };

            userManager.CreateAsync(user, password);
            
            return user;
        }
    }
}