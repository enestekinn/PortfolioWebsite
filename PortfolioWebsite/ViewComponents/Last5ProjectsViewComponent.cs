using Microsoft.AspNetCore.Mvc;

namespace PortfolioWebsite.ViewComponents
{
    public class Last5ProjectsViewComponent : ViewComponent
    {
        
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}