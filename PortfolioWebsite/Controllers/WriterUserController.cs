using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace PortfolioWebsite.Controllers
{
    public class WriterUserController : Controller
    {
        private WriterUserManager _userManager = new WriterUserManager(new EfWriterUserDal());

        // GET
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ListUser()
        {
            var values = JsonConvert.SerializeObject(_userManager.TGetList());
            return Json(values);
        }

        [HttpPost]
        public IActionResult AddUser(WriterUser writerUser)
        {
            _userManager.TAdd(writerUser);
            var values = JsonConvert.SerializeObject(writerUser);
            return Json(values);
        }

       
    }
}