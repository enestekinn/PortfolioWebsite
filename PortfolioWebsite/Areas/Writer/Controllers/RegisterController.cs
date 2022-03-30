using System.Threading.Tasks;
using EntityLayer.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PortfolioWebsite.Areas.Writer.Models;

namespace PortfolioWebsite.Areas.Writer.Controllers
{
    [Area("Writer")]
    public class RegisterController : Controller
    {

        private readonly UserManager<WriterUser> _userManager;

        public RegisterController(UserManager<WriterUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View(new UserRegisterViewModel());
        }

        [HttpPost]
        public async Task<IActionResult> Index(UserRegisterViewModel userRegister)
        {
            
            if (ModelState.IsValid)
            {
                WriterUser writerUser = new WriterUser()
                {
                    Name = userRegister.Name,
                    Surname = userRegister.Surname,
                    Email = userRegister.Mail,
                    UserName = userRegister.Username,
                    ImageUrl = userRegister.ImageUrl
                };
                if (userRegister.Password == userRegister.ConfirmPassword)
                {
                    
                    var result = await _userManager.CreateAsync(writerUser, userRegister.Password);
                    if (result.Succeeded)
                    {
                        return RedirectToAction("Index", "Login");
                    }
                    else
                    {
                        foreach (var item in result.Errors)
                        {
                            ModelState.AddModelError("",item.Description);
                        }
                    }
                }
            }
            return View();
        }
    }
}