using System;
using System.Linq;
using System.Threading.Tasks;
using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace PortfolioWebsite.Areas.Writer.Controllers
{
    
    [Area("Writer")]
    [Route("Writer/[controller]/[action]")]
    public class MessageController : Controller
    {
        
        WriterMessageManager writerMessageManager = new WriterMessageManager(new EfWriterMessageDal());
            
        private readonly  UserManager<WriterUser> _userManager;

        public MessageController(UserManager<WriterUser> userManager)
        {
            _userManager = userManager;
        }
        
        [Route("")]
        [Route("ReceiverMessage")]
        public async Task<IActionResult> ReceiverMessage(string message)
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            message = values.Email;
            var messageList = writerMessageManager.GetListReceiverMessage(message);
     

            return View(messageList);
        }

        
        [Route("")]
        [Route("SenderMessage")]
        public async Task<IActionResult> SenderMessage(string message)
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            message = values.Email;
            var messageList = writerMessageManager.GetListSenderMessage(message);
            return View(messageList);
        }

        [Route("ReceiverMessageDetails/{id}")]
        public IActionResult MessageDetails(int id)
        {
            WriterMessage writerMessage = writerMessageManager.TGetById(id);
            return View(writerMessage);
        }

        public IActionResult ReceiverMessageDetails(int id)
        {
            WriterMessage writerMessage = writerMessageManager.TGetById(id);
            return View(writerMessage);
        }

        [HttpGet]
        public IActionResult SendMessage()
        {
            return View();
        }

        [HttpPost]
        public  async Task<IActionResult> SendMessage(WriterMessage writerMessage)
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            string mail = values.Email;
            string name = values.Name + " " + values.Surname;
            writerMessage.Date = Convert.ToDateTime(DateTime.Now.ToLongDateString());
            writerMessage.Sender = mail;
            writerMessage.SenderName = name;
            Context context = new Context();
            var usernameSurname = context.Users
                .Where(x => x.Email == writerMessage.Receiver)
                .Select(y => y.Name + " " + y.Surname).FirstOrDefault();
            writerMessage.ReceiverName = usernameSurname;
            writerMessageManager.TAdd(writerMessage);
            return RedirectToAction("SenderMessage");
        }
    }
}