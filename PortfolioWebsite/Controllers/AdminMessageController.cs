using System;
using System.Linq;
using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Models;
using Microsoft.AspNetCore.Mvc;

namespace PortfolioWebsite.Controllers
{
    public class AdminMessageController : Controller
    {
        private WriterMessageManager _writerMessageManager = new WriterMessageManager(new EfWriterMessageDal());

        public IActionResult ReceiverMessageList()
        {
            string admin;
            admin = "admin@gmail.com";
            var values = _writerMessageManager.GetListReceiverMessage(admin);
            return View(values);
        }

        public IActionResult SenderMessageList()
        {
            string admin;
            admin = "admin@gmail.com";
            var values = _writerMessageManager.GetListSenderMessage(admin);
            return View(values);
        }

        public IActionResult AdminMessageDetails(int id)
        {
            var values = _writerMessageManager.TGetById(id);
            return View(values);
        }

        public IActionResult AdminMessageDelete(int id)
        {
            var values = _writerMessageManager.TGetById(id);
            _writerMessageManager.TDelete(values);
            return RedirectToAction("SenderMessageList");
        }

        [HttpGet]
        public IActionResult AdminMessageSend()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AdminMessageSend(WriterMessage writerMessage)
        {
            writerMessage.Sender = "admin@gmail.com";
            writerMessage.SenderName = "Admin";
            writerMessage.Date = DateTime.Parse(DateTime.Now.ToShortDateString());

            Context context = new Context();
            var usernameSurname = context.Users.Where(x => x.Email == writerMessage.Receiver)
                .Select(y => y.Name + " " + y.Surname).FirstOrDefault();
            writerMessage.ReceiverName = usernameSurname;
            _writerMessageManager.TAdd(writerMessage);

            return RedirectToAction("SenderMessageList");

        }
        
    }
}