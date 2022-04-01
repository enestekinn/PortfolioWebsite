using System;
using System.IO;
using System.Threading.Tasks;
using EntityLayer.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PortfolioWebsite.Areas.Writer.Models;

namespace PortfolioWebsite.Areas.Writer.Controllers
{
    
    [Area("Writer")]
    [Route("Writer/[controller]/[action]")]
    public class ProfileController : Controller
    {
        private readonly UserManager<WriterUser> _userManager;

        public ProfileController(UserManager<WriterUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            
            var values  = await _userManager.FindByNameAsync(User.Identity.Name);
            Console.WriteLine("*************   "+values);
            UserEditViewModel model = new UserEditViewModel();
            model.Name = values.Name;
            model.Surname = values.Surname;
            model.PictureUrl = values.ImageUrl;
            
            return View(model);

        }

        public async Task<IActionResult> Index(UserEditViewModel userEditViewModel)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            if (userEditViewModel.Picture != null)
            {
                var resource = Directory.GetCurrentDirectory();
                var extension = Path.GetExtension(userEditViewModel.Picture.FileName);
                var imageName = Guid.NewGuid() + extension;
                var saveLocation = resource + "/wwwroot/userimage/" + imageName;
                var stream = new FileStream(saveLocation, FileMode.Create);
                await userEditViewModel.Picture.CopyToAsync(stream);
                user.ImageUrl = imageName;
            }

            user.Name = userEditViewModel.Name;
            user.Surname = userEditViewModel.Surname;
            user.PasswordHash = _userManager.PasswordHasher.HashPassword(user, userEditViewModel.Password);
            var result = await _userManager.UpdateAsync(user);
            if (result.Succeeded)
            {
                return RedirectToAction("Index", "Default");
            }

            return View();
        }
    }
}