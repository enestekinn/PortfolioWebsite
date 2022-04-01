using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Models;
using Microsoft.AspNetCore.Mvc;

namespace PortfolioWebsite.Controllers
{
    public class TestimonialController : Controller
    {
        private TestimonialManager _testimonialManager = new TestimonialManager(new EfTestimonialDal());
        
        public IActionResult Index()
        {
            var values = _testimonialManager.TGetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddTestimonial()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddTestimonial(Testimonial p)
        {
            _testimonialManager.TAdd(p);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteTestimonial(int id)
        {
            var values = _testimonialManager.TGetById(id);
            _testimonialManager.TDelete(values);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult EditTestimonial(int id)
        {
            var values = _testimonialManager.TGetById(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult EditTestimonial(Testimonial testimonial)
        {
            _testimonialManager.TUpdate(testimonial);
            return RedirectToAction("Index");
        }
    }
}