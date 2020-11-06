using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MEG_Boosting_Site.Data;
using MEG_Boosting_Site.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;


namespace MEG_Boosting_Site.Controllers
{
    public class CustomOrderController : Controller
    {
        private readonly ApplicationDbContext _db;
        private readonly UserManager<ApplicationUser> _userManager;

        public CustomOrderController(ApplicationDbContext db, UserManager<ApplicationUser> userManager)
        {
            _db = db;
            _userManager = userManager;
        }
        
        
        // GET
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        
        [HttpGet]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> CustomOrderView()
        {
            return View(await _db.CustomOrders.Include(a => a.ApplicationUser).OrderByDescending(a => a.Id)
                .ToListAsync());
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<IActionResult> Add([Bind("Name,Details")] CustomOrder customorder)
        {
            var user = _userManager.GetUserAsync(User).Result;
            if (user == null)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                customorder.ApplicationUser = user;
                _db.Add(customorder);
                await _db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            return View(customorder);
        }
        
        
    }
}