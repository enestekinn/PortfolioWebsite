using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Models;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace PortfolioWebsite.Controllers
{
    public class PortfolioController : Controller
    {

        private PortfolioManager _portfolioManager = new PortfolioManager(new EfPortfolioDal());

        public IActionResult Index()
        {
            var values = _portfolioManager.TGetList();
            return View(values);
        }

        public IActionResult AddPortfolio()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddPortfolio(Portfolio portfolio)
        {
            PortfolioValidator validator = new PortfolioValidator();
            ValidationResult result = validator.Validate(portfolio);
            if (result.IsValid)
            {
                _portfolioManager.TAdd(portfolio);
                return RedirectToAction("Index");
            }

            foreach (var item in result.Errors)
            {
                ModelState.AddModelError(item.PropertyName,item.ErrorMessage);
                
            }

            return View();
        }

        public IActionResult DeletePortfolio(int id)
        {
            var values = _portfolioManager.TGetById(id);
            _portfolioManager.TDelete(values);
            return RedirectToAction("Index");
        }

        public IActionResult EditPortfolio(Portfolio portfolio)
        {
            PortfolioValidator validator = new PortfolioValidator();
            ValidationResult result = validator.Validate(portfolio);
            if (result.IsValid)
            {
                _portfolioManager.TUpdate(portfolio);
                return RedirectToAction("Index");
            }

            foreach (var item in result.Errors)
            {
                ModelState.AddModelError(item.PropertyName,item.ErrorMessage);
                
            }
            return View();

        }
    }
}