using ETdea.Librarys.Mail;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin;
using SimpleBackend.Models;
using SimpleBackend.Stores;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.WebPages;

namespace SimpleBackend.Managers
{
    public class SmsService : IIdentityMessageService
    {
        public Task SendAsync(IdentityMessage message)
        {
            // 將您的 SMS 服務外掛到這裡以傳送簡訊。
            return Task.FromResult(0);
        }
    }

    // Configure the application user manager used in this application. UserManager is defined in ASP.NET Identity and is used by the application.
    public class UserManager : UserManager<User, int>
    {
        private UserStore store { get { return Store as UserStore; } }

        public UserManager(IUserStore<User, int> store)
            : base(store)
        {

        }

        public static UserManager Create(IdentityFactoryOptions<UserManager> options,
            IOwinContext context)
        {
            var manager = new UserManager(new UserStore(context.Get<MyDbContext>()));
            // Configure validation logic for usernames
            manager.UserValidator = new UserValidator<User, int>(manager)
            {
                AllowOnlyAlphanumericUserNames = false,
                RequireUniqueEmail = false
            };
            // Configure validation logic for passwords
            manager.PasswordValidator = new PasswordValidator
            {
                RequiredLength = 5,
                RequireNonLetterOrDigit = false,
                RequireDigit = true,
                RequireLowercase = false,
                RequireUppercase = false,
            };
            // Configure user lockout defaults
            manager.UserLockoutEnabledByDefault = true;
            manager.DefaultAccountLockoutTimeSpan = TimeSpan.FromMinutes(5);
            manager.MaxFailedAccessAttemptsBeforeLockout = 5;
            // Register two factor authentication providers. This application uses Phone and Emails as a step of receiving a code for verifying the user
            // You can write your own provider and plug in here.
            manager.RegisterTwoFactorProvider("PhoneCode", new PhoneNumberTokenProvider<User, int>
            {
                MessageFormat = "Your security code is: {0}"
            });
            manager.RegisterTwoFactorProvider("EmailCode", new EmailTokenProvider<User, int>
            {
                Subject = "SecurityCode",
                BodyFormat = "Your security code is {0}"
            });

            manager.EmailService = new SmtpClient();
            manager.SmsService = new SmsService();
            var dataProtectionProvider = options.DataProtectionProvider;
            if (dataProtectionProvider != null)
            {
                manager.UserTokenProvider =
                    new DataProtectorTokenProvider<User, int>(dataProtectionProvider.Create("ASP.NET Identity"));
            }
            return manager;
        }

        public void RemoveAll(IEnumerable<int> id)
        {
            store.DeleteAll(id);
        }

        public override async Task<System.Security.Claims.ClaimsIdentity> CreateIdentityAsync(User user, string authenticationType)
        {
            var identity = await base.CreateIdentityAsync(user, authenticationType);

            //identity.AddClaim(new Claim(ClaimTypes.Role, "Rolename"));

            return identity;
        }

        public IEnumerable<User> Find()
        {
            return store.FindAll();
        }

        public override async Task<IdentityResult> UpdateAsync(User source)
        {
            var model = await FindByIdAsync(source.Id);

            if (!source.PasswordHash.IsEmpty())
            {
                model.PasswordHash = source.PasswordHash;
            }

            model.UserName = source.UserName;
            model.Email = source.Email;
            model.Enabled = source.Enabled;

            return await base.UpdateAsync(model);
        }
    }
}