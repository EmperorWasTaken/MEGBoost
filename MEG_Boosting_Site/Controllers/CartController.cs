using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using MEG_Boosting_Site.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MEG_Boosting_Site.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;


namespace MEG_Boosting_Site.Controllers
{
    public class CartController : Controller
    {
        private readonly ApplicationDbContext _db;
        private readonly UserManager<ApplicationUser> _userManager;
        public CartController(ApplicationDbContext db, UserManager<ApplicationUser> userManager)
        {
            _db = db;
            _userManager = userManager;
        }
        
        public IActionResult Index()
        {
            return View();
        }
        
        [HttpGet]
        [Authorize]
        public async Task<IActionResult> Cart()
        {
            var user = _userManager.GetUserAsync(User).Result;
            ViewBag.UserId = user.Id;
            return View(await _db.Orders.Include(a => a.ApplicationUser).OrderByDescending(a => a.Id)
                .ToListAsync());
        }
}
}