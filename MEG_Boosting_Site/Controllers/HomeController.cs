using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using MEG_Boosting_Site.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MEG_Boosting_Site.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace MEG_Boosting_Site.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _db;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext db)
        {
            _logger = logger;
            _db = db;
        }

        public IActionResult Index()
        {
            var vm = new BestsellersTopReviewsViewModel
            {
                Products = _db.Products.Where(b => b.BestSeller.Equals(true)).ToList(),
                Reviews = _db.Reviews.Include(a => a.ApplicationUser).Where(t => t.TopReview.Equals(true)).ToList()
            };   
            
            return View(vm);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult FAQ()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
