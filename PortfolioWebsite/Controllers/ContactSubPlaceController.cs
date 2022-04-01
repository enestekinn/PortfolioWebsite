using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Models;
using Microsoft.AspNetCore.Mvc;

namespace PortfolioWebsite.Controllers
{
    public class ContactSubPlaceController : Controller
    {
        private ContactManager _contactManager = new ContactManager(new EfContactDal());

        
        [HttpGet]
        public IActionResult Index()
        {
            var values = _contactManager.TGetById(1);
            return View(values);
        }

        [HttpPost]
        public IActionResult Index(Contact contact)
        {
            _contactManager.TUpdate(contact);
            return RedirectToAction("Index", "Default");

        }

    }
}