using System.ComponentModel.DataAnnotations;

namespace PortfolioWebsite.Areas.Writer.Models
{
    public class UserLoginViewModel
    {
        [Display(Name="Kullanici Adi")]
        [Required(ErrorMessage = "Kullanici Adini giriniz...!")]
        public string Username { get; set; }
        [Display(Name="Sifre ")]
        [Required(ErrorMessage = "Sifreyi giriniz...!")]
        public string Password { get; set; }
    }
}