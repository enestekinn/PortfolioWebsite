using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace PortfolioWebsite.Controllers
{
    [Authorize(Roles = "Admin")]
    public class ExperienceController : Controller
    {
        private ExperienceManager _experienceManager = new ExperienceManager(new EfExperienceDal());

        public IActionResult Index()
        {
            var values = _experienceManager.TGetList();
            return View(values);
        }
//TODO neden iki tane olusturuduk
        [HttpGet]
        public IActionResult AddExperience()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddExperience(Experience experience)
        {
            _experienceManager.TAdd(experience);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteExperience(int id)
        {
            var values = _experienceManager.TGetById(id);
            _experienceManager.TDelete(values);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult EditExperience(int id)
        {
            var values = _experienceManager.TGetById(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult EditExperience(Experience experience)
        {
            _experienceManager.TUpdate(experience);
            return RedirectToAction("Index");
        }
            
        
    }
}