using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace PortfolioWebsite.ViewComponents
{
    public class SkillListViewComponent : ViewComponent
    {
        private SkillManager skillManager = new SkillManager(new EfSkillDal());
        
        public IViewComponentResult Invoke()
        {
            var values = skillManager.TGetList();
            return View(values);
        }

    }
}