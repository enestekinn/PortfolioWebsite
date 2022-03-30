using System.ComponentModel.DataAnnotations;

namespace PortfolioWebsite.Areas.Writer.Models
{
    public class UserRegisterViewModel
    {
        [Required(ErrorMessage = "Lütfen adınızı giriniz.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Lütfen soy adınızı giriniz.")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Lutfen resim url degeri girin.")]
        public string ImageUrl { get; set; }

        [Required(ErrorMessage = "Lutfen kullanici adini girin.")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Lutfen sifreyi  girin.")]

        public string Password { get; set; }

        [Required(ErrorMessage = "Lutfen sifreyi tekrar  girin.")]
        [Compare("Password", ErrorMessage = "Sifreler uyumlu degil")]

        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "Lutfen mail  girin.")]

        public string Mail { get; set; }
    }
}