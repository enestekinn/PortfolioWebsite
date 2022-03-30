using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace PortfolioWebsite.Areas.Writer.Controllers
{
    [Area("Writer")]
    public class DefaultController : Controller
    {

        private AnnouncementManager _announcementManager = new AnnouncementManager(new EfAnnouncementDal());
        // GET
        public IActionResult Index()
        {
            var values = _announcementManager.TGetList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AnnouncementDetails(int id)
        {
            var values = _announcementManager.TGetById(id);
            return View(values);
        }
    }
}