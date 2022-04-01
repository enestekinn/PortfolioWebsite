using Microsoft.AspNetCore.Mvc;

namespace PortfolioWebsite.ViewComponents
{
    public class VisitorMapViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}