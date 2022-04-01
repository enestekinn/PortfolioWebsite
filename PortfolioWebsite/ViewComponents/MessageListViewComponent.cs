using System.Linq;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace PortfolioWebsite.ViewComponents
{
    public class MessageListViewComponent : ViewComponent
    {
        
        MessageManager messageManager = new MessageManager(new EfMessageDal());
        public IViewComponentResult Invoke()
        {
            var values = messageManager.TGetList().Take(5).ToList();
            return View(values);
        }
    }
}