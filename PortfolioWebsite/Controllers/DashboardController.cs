using Microsoft.AspNetCore.Mvc;

namespace PortfolioWebsite.Controllers
{
    public class DashboardController : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View();
        }
    }
}