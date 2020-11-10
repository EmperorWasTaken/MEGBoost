﻿using System.Linq;
using System.Threading.Tasks;
using MEG_Boosting_Site.Data;
using MEG_Boosting_Site.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MEG_Boosting_Site.Controllers
{
    public class SchoolSubjectController : Controller
    {
        private readonly ApplicationDbContext _db;

        private readonly UserManager<ApplicationUser> _userManager;

        public SchoolSubjectController(ApplicationDbContext db, UserManager<ApplicationUser> userManager)
        {
            _db = db;
            _userManager = userManager;
        }
        
        // GET
        public async Task<IActionResult> ROne()
        {
            var ROne = _db.Products.Where(n => n.Service.Equals("R1")).ToListAsync();
            return View(await ROne);
        }
        
        public async Task<IActionResult> RTwo()
        {
            var RTwo = _db.Products.Where(n => n.Service.Equals("R2")).ToListAsync();
            return View(await RTwo);
        }
        
        public async Task<IActionResult> MOne()
        {
            var MOne = _db.Products.Where(n => n.Service.Equals("M1")).ToListAsync();
            return View(await MOne);
        }
        
        public async Task<IActionResult> MTwo()
        {
            var MTwo = _db.Products.Where(n => n.Service.Equals("M2")).ToListAsync();
            return View(await MTwo);
        }

        public async Task<IActionResult> MThree()
        {
            var MThree = _db.Products.Where(n => n.Service.Equals("M3")).ToListAsync();
            return View(await MThree);
        }
        
        public async Task<IActionResult> DiscreteMOne()
        {
            var DMOne = _db.Products.Where(n => n.Service.Equals("DM1")).ToListAsync();
            return View(await DMOne);
        }
        
        public async Task<IActionResult> DiscreteMTwo()
        {
            var DMTwo = _db.Products.Where(n => n.Service.Equals("DM2")).ToListAsync();
            return View(await DMTwo);
        }
    }
}