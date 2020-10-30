using Microsoft.AspNetCore.Mvc;

namespace MEG_Boosting_Site.Controllers
{
    public class WorldOfWarcraftController : Controller
    {
        // GET
        public IActionResult ClassicIndex()
        {
            return View();
        }
        
        // GET
        public IActionResult RetailIndex()
        {
            return View();
        }
    }
}