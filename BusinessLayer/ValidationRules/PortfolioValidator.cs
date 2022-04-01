using EntityLayer.Models;
using FluentValidation;

namespace BusinessLayer.ValidationRules
{
    public class PortfolioValidator  : AbstractValidator<Portfolio>
    {
        public PortfolioValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Proje Adi bos gecilemez");
            RuleFor(x => x.ImageUrl).NotEmpty().WithMessage("Gorsel  Adi bos gecilemez");
            RuleFor(x => x.ImageUrl2).NotEmpty().WithMessage("Gorsel2  Adi bos gecilemez");
            RuleFor(x => x.Price).NotEmpty().WithMessage("Fiyat Alani Bos Gecilemez");
            RuleFor(x => x.Value).NotEmpty().WithMessage("Fiyat Alani Bos Gecilemez");
            RuleFor(x => x.Name).MinimumLength(5).WithMessage("Proje adi en az 5 karekterden olusmak zorundadir.");
            RuleFor(x => x.Name).MaximumLength(100).WithMessage("Proje adi en fazla 100 karekterden olusmak zorundadir.");
            
        }
    }
}