using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using SimpleBackend.Managers;
using System.Web;
using System.Web.Mvc;

namespace SimpleBackend.Controllers
{
    public partial class BaseController : Controller
    {
        private SignInManager _signInManager;
        private UserManager _userManager;

        public SignInManager SignInManager
        {
            get
            {
                return _signInManager ?? HttpContext.GetOwinContext().Get<SignInManager>();
            }
            protected set
            {
                _signInManager = value;
            }
        }
        public UserManager UserManager
        {
            get
            {
                return _userManager ?? HttpContext.GetOwinContext().GetUserManager<UserManager>();
            }
            protected set
            {
                _userManager = value;
            }
        }

        public IAuthenticationManager AuthenticationManager
        {
            get
            {
                return HttpContext.GetOwinContext().Authentication;
            }
        }
    }
}