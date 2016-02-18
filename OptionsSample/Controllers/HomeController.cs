using Microsoft.AspNet.Mvc;
using Microsoft.Extensions.OptionsModel;
using OptionsSample.Utils;

namespace OptionsSample.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppSettings Settings;

        public HomeController(IOptions<AppSettings> settings){
            Settings = settings.Value;
        }

        public IActionResult Index()
        {
            ViewData["AppVersion"] = Settings.AppVersion;
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
