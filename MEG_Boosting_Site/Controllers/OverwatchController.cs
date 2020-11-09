using Microsoft.AspNetCore.Mvc;

namespace MEG_Boosting_Site.Controllers
{
    public class OverwatchController : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Ranked()
        {
            return View();
        }
        public IActionResult Coaching()
        {
            return View();
        }
        public IActionResult Levling()
        {
            return View();
        }
    }
}