using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;

namespace MEG_Boosting_Site.Controllers
{
    public class CSGOController : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View();
        }
        [Route("/CSGO/Competitive", Name = "competitive")]
        public IActionResult Competitive()
        {
            return View();
        }
        public IActionResult Wingman()
        {
            return View();
        }
        public IActionResult ESEA()
        {
            return View();
        }
        public IActionResult Faceit()
        {
            return View();
        }
    }
}