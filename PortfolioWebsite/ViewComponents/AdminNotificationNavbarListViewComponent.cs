using System.Linq;
using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace PortfolioWebsite.ViewComponents
{
    public class AdminNotificationNavbarListViewComponent : ViewComponent
    {
        private Context _context = new Context();
        public IViewComponentResult Invoke()
        {
            ViewBag.v1 = _context.Portfolios.Count();
            ViewBag.v2 = _context.Messages.Count();
            ViewBag.v3 = _context.Services.Count();   
            
            return View();
        }
    }
}