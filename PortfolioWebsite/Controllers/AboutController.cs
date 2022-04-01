using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Models;
using Microsoft.AspNetCore.Mvc;

namespace PortfolioWebsite.Controllers
{
    public class AboutController : Controller
    {
        private AboutManager _aboutManager = new AboutManager(new EfAboutDal());

        public IActionResult Index()
        {
            var values = _aboutManager.TGetById(1);
            return View(values);
        }

        [HttpPost]
        public IActionResult Index(About about)
        {
            _aboutManager.TUpdate(about);
            return RedirectToAction("Index", "Default");
        }

    }
}