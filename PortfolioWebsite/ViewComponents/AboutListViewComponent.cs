using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace PortfolioWebsite.ViewComponents
{
    public class AboutListViewComponent : ViewComponent
    {
        private AboutManager _aboutManager = new AboutManager(new EfAboutDal());

        public IViewComponentResult Invoke()
        {
            var values = _aboutManager.TGetList();
            return View(values);
        }
    }
}