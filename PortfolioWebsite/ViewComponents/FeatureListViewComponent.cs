using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace PortfolioWebsite.ViewComponents
{

    public class FeatureList : ViewComponent
    {
        private FeatureManager _featureManager = new FeatureManager(new EfFeatureDal());

        public IViewComponentResult Invoke()
        {
            var values = _featureManager.TGetList();
            return View(values);
        }

    }
}