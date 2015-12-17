using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security;
using System.Linq;
using System.ComponentModel;
using SimpleBackend.Models;

namespace SimpleBackend.ViewModels
{
    public class IndexViewModel
    {
        public bool HasPassword { get; set; }
        public IList<UserLoginInfo> Logins { get; set; }
        public string PhoneNumber { get; set; }
        public bool TwoFactor { get; set; }
        public bool BrowserRemembered { get; set; }
    }

    public class ManageLoginsViewModel
    {
        public IList<UserLoginInfo> CurrentLogins { get; set; }
        public IList<AuthenticationDescription> OtherLogins { get; set; }
    }

    public class FactorViewModel
    {
        public string Purpose { get; set; }
    }

    public class SetPasswordViewModel
    {
        [Required]
        [StringLength(100, ErrorMessage = "{0} 至少要 {2} 個字元.", MinimumLength = 5)]//The {0} must be at least {2} characters long.
        [DataType(DataType.Password)]
        [Display(Name = "新密碼")]
        public string NewPassword { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "確認新密碼")]
        [Compare("NewPassword", ErrorMessage = "{1} 和 {0} 不相同.")]//The new password and confirmation password do not match.
        public string ConfirmPassword { get; set; }
    }

    public class ChangePasswordViewModel : SetPasswordViewModel
    {
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "舊密碼")]//Current password
        public string OldPassword { get; set; }
    }

    public class AddPhoneNumberViewModel
    {
        [Required]
        [Phone]
        [Display(Name = "Phone Number")]
        public string Number { get; set; }
    }

    public class VerifyPhoneNumberViewModel
    {
        [Required]
        [Display(Name = "Code")]
        public string Code { get; set; }

        [Required]
        [Phone]
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }
    }

    public class ConfigureTwoFactorViewModel
    {
        public string SelectedProvider { get; set; }
        public ICollection<System.Web.Mvc.SelectListItem> Providers { get; set; }
    }


    public class UserEditViewModel : SetPasswordViewModel, ICast
    {
        public int Id { get; set; }
        
        [DisplayName("帳號")]
        [DataType(DataType.Text)]
        public string UserName { get; set; }

        [DisplayName("電子郵件")]
        [DataType(DataType.Text)]
        public string Email { get; set; }

        [DisplayName("電話號碼")]
        [DataType(DataType.Text)]
        public string PhoneNumber { get; set; }

        [DisplayName("停用")]
        public bool Disable { get; set; }

        static public explicit operator UserEditViewModel(User source)
        {
            var model = source.To<UserEditViewModel>();
            return model;
        }
        static public explicit operator User(UserEditViewModel source)
        {
            var model = source.To<User>();
            return model;
        }
    }

    public class UserListViewModel : ICast
    {
        [DataType("Check")]
        public int Id { get; set; }

        [DisplayName("帳號")]
        [DataType(DataType.Text)]
        public string UserName { get; set; }

        [DisplayName("電子郵件")]
        [DataType(DataType.Text)]
        public string Email { get; set; }

        [DisplayName("電話號碼")]
        [DataType(DataType.Text)]
        public string PhoneNumber { get; set; }

        [DisplayName("停用")]
        public bool Disable { get; set; }

        static public explicit operator UserListViewModel(User source)
        {
            var model = source.To<UserListViewModel>();
            return model;
        }
        internal static IEnumerable<UserListViewModel> Parser(IEnumerable<User> source)
        {
            return source.Select(p => (UserListViewModel)p);
        }
    }
}