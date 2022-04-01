using System.Threading.Tasks;
using EntityLayer.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PortfolioWebsite.Areas.Writer.Models;

namespace PortfolioWebsite.Areas.Writer.Controllers
{
    [AllowAnonymous]
    [Area("Writer")]
    [Route("Writer/[controller]/[action]")]
    public class LoginController : Controller
    {
        private readonly SignInManager<WriterUser> _signInManager;

        public LoginController(SignInManager<WriterUser> signInManager)
        {
            _signInManager = signInManager;
        }
        // GET
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(UserLoginViewModel userLoginViewModel)
        {
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(userLoginViewModel.Username,
                    userLoginViewModel.Password, true, true);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Profile", new {area = "Writer"});
                }
                else
                {
                    ModelState.AddModelError("","Hatali Kullanici adi ve ya sifre");
                }
            }

            return View();
            
            }

        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Login");
        }
    }
}