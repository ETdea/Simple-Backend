using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin;
using Microsoft.Owin.Security;
using SimpleBackend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;

namespace SimpleBackend.Managers
{
    public class SignInManager : SignInManager<User, int>
    {
        public SignInManager(UserManager userManager, IAuthenticationManager authenticationManager) :
            base(userManager, authenticationManager)
        { }

        public override Task<ClaimsIdentity> CreateUserIdentityAsync(User user)
        {
            return user.GenerateUserIdentityAsync((UserManager)UserManager);
        }

        public static SignInManager Create(IdentityFactoryOptions<SignInManager> options, IOwinContext context)
        {
            return new SignInManager(context.GetUserManager<UserManager>(), context.Authentication);
        }

        public override async Task<SignInStatus> PasswordSignInAsync(string userName, string password, bool isPersistent, bool shouldLockout)
        {
            if (!(await UserManager.FindByNameAsync(userName))?.Enabled ?? false)
            {
                return SignInStatus.Failure;
            }

            return await base.PasswordSignInAsync(userName, password, isPersistent, shouldLockout);
        }
    }
}