using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security;

namespace DejtingSajt.Models
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
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "New password")]
        public string NewPassword { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm new password")]
        [Compare("NewPassword", ErrorMessage = "The new password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
    }

    public class ChangePasswordViewModel
    {
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Current password")]
        public string OldPassword { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "New password")]
        public string NewPassword { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm new password")]
        [Compare("NewPassword", ErrorMessage = "The new password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
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

    public class ChangeUsernameViewModel
    {
        [Required]
        [Display(Name = "Befintligt användarnamn")]
        public string OldUsername { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Användarnamnet {0} måste vara {2} tecken långt", MinimumLength = 4)]
        [Display(Name = "Nytt användarnamn")]
        public string NewUsername { get; set; }

        [Display(Name = "Bekräfta nytt användarnamn")]
        [Compare("NewUsername", ErrorMessage = "Användarnamnet måste matcha!")]
        public string ConfirmUsername { get; set; }
    }

    public class ChangeFirstnameViewMModel
    {
        [Required]
        [Display(Name = "Befintligt förnamn")]
        public string OldFirstname { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Förnamnet {0} måste vara {2} tecken långt", MinimumLength = 4)]
        [Display(Name = "Nytt förnamn")]
        public string NewFirstname { get; set; }

        [Display(Name = "Bekräfta nytt förnamn")]
        [Compare("NewFirstname", ErrorMessage = "Förnamnen måste matcha!")]
        public string ConfirmFirstname { get; set; }

    }


    public class ChangeLastnameViewModel
    {

        [Required]
        [Display(Name = "Befintligt efternamn")]
        public string OldLastname { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Efternamnet {0} måste vara {2} tecken långt", MinimumLength = 4)]
        [Display(Name = "Nytt efternamn")]
        public string NewLastname { get; set; }

        [Display(Name = "Bekräfta nytt efternamn")]
        [Compare("NewLastname", ErrorMessage = "Efternamnen måste matcha!")]
        public string ConfirmLastname { get; set; }
    }
}