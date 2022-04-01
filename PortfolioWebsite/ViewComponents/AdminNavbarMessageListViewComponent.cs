using System.Linq;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace PortfolioWebsite.ViewComponents
{
    public class AdminNavbarMessageListViewComponent : ViewComponent
    {
        WriterMessageManager writerMessageManager = new WriterMessageManager(new EfWriterMessageDal());
        public IViewComponentResult Invoke()
        {
            string p = "admin@gmail.com";
            var values = writerMessageManager.GetListReceiverMessage(p).OrderByDescending(x=>x.WriterMessageId).Take(3).ToList();
            return View(values);
        }
    }
}