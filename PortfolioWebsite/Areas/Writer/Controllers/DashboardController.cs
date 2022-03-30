using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;
using DataAccessLayer.Concrete;
using EntityLayer.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace PortfolioWebsite.Areas.Writer.Controllers
{
    [Area("Writer")]
    public class DashboardController : Controller
    {
        

        private readonly UserManager<WriterUser> _userManager;

        public DashboardController(UserManager<WriterUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.v = values.Name + "" + values.Surname;
            
            //Api
            string api = "89c878e2b9b63ad2b8418eee6d32c444";
            string connection = "https://api.openweathermap.org/data/2.5/weather?q=istanbul&mode=xml&appid=" + api+"&units=metric";
            XDocument document = XDocument.Load(connection);
            var weatherDegree =document.Descendants("temperature").ElementAt(0).Attribute("value").Value;
            weatherDegree = weatherDegree.Substring(0, weatherDegree.IndexOf("."));

            ViewBag.weatherDegree = weatherDegree;
            Context context = new Context();
            ViewBag.announmentCount = context.Announcements.Count();
            ViewBag.users = context.Users.Count();
            ViewBag.skills = context.Skills.Count();
            return View();
        }
    }
}