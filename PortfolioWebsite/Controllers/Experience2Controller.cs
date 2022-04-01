using System.Net.Http.Json;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace PortfolioWebsite.Controllers
{
    public class Experience2Controller : Controller
    {
        private ExperienceManager _experienceManager = new ExperienceManager(new EfExperienceDal());
        // GET
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ListExperience()
        {
            var values = JsonConvert.SerializeObject(_experienceManager.TGetList());
            return Json(values);
        }

        public IActionResult AddExperience(Experience experience)
        {
            _experienceManager.TAdd(experience);
            var values = JsonConvert.SerializeObject(experience);
            return Json(values);
        }

        [HttpPost]
        public IActionResult GetById(int ExperienceId)
        {
            var v = _experienceManager.TGetById(ExperienceId);
            var values = JsonConvert.SerializeObject(v);
            return Json(values);
        }

        public IActionResult DeleteExperience(int id)
        {
            var v = _experienceManager.TGetById(id);
            _experienceManager.TDelete(v);
            return NoContent();
        }
    }
}