using System.ComponentModel.DataAnnotations;

namespace Cel.Modelo.web.Models
{
    public class LoginViewModel
    {
        [Required]
        [Display(Name = "Username")]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        [Compare("Password", ErrorMessage = "The password")]
        public string Password { get; set; }

        public bool Ativo { get; set; }

    }
}
