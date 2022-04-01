using Microsoft.AspNetCore.Mvc;

namespace PortfolioWebsite.ViewComponents
{
    public class StatisticsDashboard2ViewComponent : ViewComponent
    {
        
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}