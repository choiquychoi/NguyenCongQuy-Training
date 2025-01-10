using System.ComponentModel.DataAnnotations;

namespace OnlineShop.Areas.Admin.Models
{
    public class LoginModel
    {
        [Required (ErrorMessage = "Please enter user name")]
        [Display(Name = "User name")]
        public string UserName { get; set; }

        [Required (ErrorMessage = "Please enter password")]
        public string Password { get; set; }

        public bool RememberMe { get; set; }
    }
}
