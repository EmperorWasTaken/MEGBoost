using Microsoft.AspNetCore.Mvc;

namespace MEG_Boosting_Site.Controllers
{
    public class LeagueOfLegendsController : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Rankedboost()
        {
            return View();
        }
        public IActionResult Winsboost()
        {
            return View();
        }
    }
}