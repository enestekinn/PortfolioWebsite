using Microsoft.AspNetCore.Mvc;

namespace PortfolioWebsite.Controllers
{
    public class ErrorPageController : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Error404()
        {
            return View();
        }
    }
}