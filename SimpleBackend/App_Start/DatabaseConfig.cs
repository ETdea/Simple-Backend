using Microsoft.AspNet.Identity.Owin;
using SimpleBackend.Managers;
using SimpleBackend.Models;
using System;
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
            var user = new User { UserName = name, Created = DateTime.UtcNow, Updated = DateTime.UtcNow };

            userManager.CreateAsync(user, password);
            user.Id = 0;

            return user;
        }
    }
}