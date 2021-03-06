using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EcommerceApp.Models
{
    public class ExternalLoginConfirmationViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }

    public class ExternalLoginListViewModel
    {
        public string ReturnUrl { get; set; }
    }

    public class SendCodeViewModel
    {
        public string SelectedProvider { get; set; }
        public ICollection<System.Web.Mvc.SelectListItem> Providers { get; set; }
        public string ReturnUrl { get; set; }
        public bool RememberMe { get; set; }
    }

    public class VerifyCodeViewModel
    {
        [Required]
        public string Provider { get; set; }

        [Required]
        [Display(Name = "Code")]
        public string Code { get; set; }
        public string ReturnUrl { get; set; }

        [Display(Name = "Remember this browser?")]
        public bool RememberBrowser { get; set; }

        public bool RememberMe { get; set; }
    }

    public class ForgotViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }

    public class LoginViewModel
    {
        [Required]
        [Display(Name = "Email")]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "password", ResourceType = typeof(EcommerceApp.Resources.Views.Account.Login))]
        public string Password { get; set; }

        [Display(Name = "remember", ResourceType = typeof(EcommerceApp.Resources.Views.Account.Login))]
        public bool RememberMe { get; set; }
    }

    public class RegisterViewModel
    {
        [Required]
        [Display(Name = "name", ResourceType = typeof(EcommerceApp.Resources.Views.Account.Register))]
        public string UserName { get; set; }
        [Required]
        [Display(Name = "adress", ResourceType = typeof(EcommerceApp.Resources.Views.Account.Register))]
        public string UserAdress { get; set; }

        [Required]
        [Display(Name = "type", ResourceType = typeof(EcommerceApp.Resources.Views.Account.Register))]
        public string UserType { get; set; }

        [Display(Name = "typeOwner")]
        public string TypeOwner { get; set; }

        [Required]
        [Display(Name = "number", ResourceType = typeof(EcommerceApp.Resources.Views.Account.Register))]
        public string UserPhone { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "email", ResourceType = typeof(EcommerceApp.Resources.Views.Account.Register))]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password", ResourceType = typeof(EcommerceApp.Resources.Views.Account.Register))]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "confirmPassword", ResourceType = typeof(EcommerceApp.Resources.Views.Account.Register))]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
    }

    public class EditViewModel
    {
        [Required]
        [Display(Name = "name", ResourceType = typeof(EcommerceApp.Resources.Views.Account.Edit))]
        public string UserName { get; set; }
        [Required]
        [Display(Name = "adress",ResourceType = typeof(EcommerceApp.Resources.Views.Account.Edit))]
        public string UserAdress { get; set; }

        [Required]
        [Display(Name = "number", ResourceType = typeof(EcommerceApp.Resources.Views.Account.Edit))]
        public string UserPhone { get; set; }


        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password",ResourceType = typeof(EcommerceApp.Resources.Views.Account.Edit))]
        public string Password { get; set; }

    }
 
    public class ResetPasswordViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

        public string Code { get; set; }
    }

    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}
