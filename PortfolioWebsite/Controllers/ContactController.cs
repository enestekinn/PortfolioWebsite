using System.Security.Cryptography.X509Certificates;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace PortfolioWebsite.Controllers
{
    public class ContactController : Controller
    {

        private MessageManager _messageManager = new MessageManager(new EfMessageDal());

        public IActionResult Index()
        {
            var values = _messageManager.TGetList();
            return View(values);

      
        }
        public IActionResult DeleteContact(int id)
        {
            var values = _messageManager.TGetById(id);
            _messageManager.TDelete(values);
            return RedirectToAction("Index");
        }

        public IActionResult ContactDetails(int id)
        {
            var values = _messageManager.TGetById(id);
            return View(values);
        }
    }
}