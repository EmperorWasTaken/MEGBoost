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
    public class CSGOController : Controller
    {
        // GET
        private readonly ApplicationDbContext _db;
        private readonly UserManager<ApplicationUser> _userManager;

        public CSGOController(ApplicationDbContext db, UserManager<ApplicationUser> userManager)
        {
            _db = db;
            _userManager = userManager;
        }
        
        
        public IActionResult Index()
        {
            return View();
        }
        
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
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<IActionResult> Competitive([Bind("Username,CurrentRank,BoostedRank")] Order order)
        {
            var user = _userManager.GetUserAsync(User).Result;
            if (user == null)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                var price1 = 0;
                var price2 = 0;
                
                switch (order.CurrentRank)
                {
                    case "1":
                        order.CurrentRank = "Silver I";
                        price1 = 200;
                        break;
                    case "2":
                        order.CurrentRank = "Silver II";
                        price1 = 190;
                        break;
                    case "3":
                        order.CurrentRank = "Silver III";
                        price1 = 180;
                        break;
                    case "4":
                        order.CurrentRank = "Silver IV";
                        price1 = 170;
                        break;
                    case "5":
                        order.CurrentRank = "Silver Elite";
                        price1 = 160;
                        break;
                    case "6":
                        order.CurrentRank = "Silver Elite Master";
                        price1 = 150;
                        break;
                    case "7":
                        order.CurrentRank = "Gold Nova I";
                        price1 = 140;
                        break;
                    case "8":
                        order.CurrentRank = "Gold Nova II";
                        price1 = 130;
                        break;
                    case "9":
                        order.CurrentRank = "Gold Nova III";
                        price1 = 120;
                        break;
                    case "10":
                        order.CurrentRank = "Gold Nova Master";
                        price1 = 110;
                        break;
                    case "11":
                        order.CurrentRank = "Master Guardian I";
                        price1 = 100;
                        break;
                    case "12":
                        order.CurrentRank = "Master Guardian II";
                        price1 = 60;
                        break;
                    case "13":
                        order.CurrentRank = "Master Guardian Elite";
                        price1 = 50;
                        break;
                    case "14":
                        order.CurrentRank = "Distinguished Master Guardian";
                        price1 = 45;
                        break;
                    case "15":
                        order.CurrentRank = "Legendary Eagle";
                        price1 = 40;
                        break;
                    case "16":
                        order.CurrentRank = "Legendary Eagle Master";
                        price1 = 35;
                        break;
                    case "17":
                        order.CurrentRank = "Supreme Master First Class";
                        price1 = 30;
                        break;
                    case "18":
                        order.CurrentRank = "Global Elite";
                        price1 = 25;
                        break;
                    default:
                        break;
                }

                switch (order.BoostedRank)
                {
                    case "1":
                        order.BoostedRank = "Silver I";
                        price2 = 10;
                        break;
                    case "2":
                        order.BoostedRank = "Silver II";
                        price2 = 20;
                        break;
                    case "3":
                        order.BoostedRank = "Silver III";
                        price2 = 30;
                        break;
                    case "4":
                        order.BoostedRank = "Silver IV";
                        price2 = 40;
                        break;
                    case "5":
                        order.BoostedRank = "Silver Elite";
                        price2 = 50;
                        break;
                    case "6":
                        order.BoostedRank = "Silver Elite Master";
                        price2 = 50;
                        break;
                    case "7":
                        order.BoostedRank = "Gold Nova I";
                        price2 = 100;
                        break;
                    case "8":
                        order.BoostedRank = "Gold Nova II";
                        price2 = 150;
                        break;
                    case "9":
                        order.BoostedRank = "Gold Nova III";
                        price2 = 200;
                        break;
                    case "10":
                        order.BoostedRank = "Gold Nova Master";
                        price2 = 250;
                        break;
                    case "11":
                        order.BoostedRank = "Master Guardian I";
                        price2 = 300;
                        break;
                    case "12":
                        order.BoostedRank = "Master Guardian II";
                        price2 = 350;
                        break;
                    case "13":
                        order.BoostedRank = "Master Guardian Elite";
                        price2 = 400;
                        break;
                    case "14":
                        order.BoostedRank = "Distinguished Master Guardian";
                        price2 = 450;
                        break;
                    case "15":
                        order.BoostedRank = "Legendary Eagle";
                        price2 = 500;
                        break;
                    case "16":
                        order.BoostedRank = "Legendary Eagle Master";
                        price2 = 550;
                        break;
                    case "17":
                        order.BoostedRank = "Supreme Master First Class";
                        price2 = 600;
                        break;
                    case "18":
                        order.BoostedRank = "Global Elite";
                        price2 = 800;
                        break;
                    default:
                        break;
                }

                
                order.Price = price1 + price2;

                order.Description ="From " + order.CurrentRank + " to " + order.BoostedRank + " on " + "Competetiv";

                order.ApplicationUser = user;
                _db.Add(order);
                await _db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            return View(order);
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<IActionResult> ESEA([Bind("Username,CurrentRank,BoostedRank")] Order order)
        {
            var user = _userManager.GetUserAsync(User).Result;
            if (user == null)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                var price1 = 0;
                var price2 = 0;
                
                switch (order.CurrentRank)
                {
                    case "1":
                        order.CurrentRank = "D-";
                        price1 = 200;
                        break;
                    case "2":
                        order.CurrentRank = "D";
                        price1 = 190;
                        break;
                    case "3":
                        order.CurrentRank = "D+";
                        price1 = 180;
                        break;
                    case "4":
                        order.CurrentRank = "C-";
                        price1 = 170;
                        break;
                    case "5":
                        order.CurrentRank = "C";
                        price1 = 160;
                        break;
                    case "6":
                        order.CurrentRank = "C+";
                        price1 = 150;
                        break;
                    case "7":
                        order.CurrentRank = "B-";
                        price1 = 140;
                        break;
                    case "8":
                        order.CurrentRank = "B";
                        price1 = 130;
                        break;
                    case "9":
                        order.CurrentRank = "B+";
                        price1 = 120;
                        break;
                    case "10":
                        order.CurrentRank = "A-";
                        price1 = 110;
                        break;
                    case "11":
                        order.CurrentRank = "A";
                        price1 = 100;
                        break;
                    case "12":
                        order.CurrentRank = "A+";
                        price1 = 60;
                        break;
                    case "13":
                        order.CurrentRank = "Rank G";
                        price1 = 50;
                        break;
                    default:
                        break;
                }

                switch (order.BoostedRank)
                {
                    case "1":
                        order.BoostedRank = "D-";
                        price2 = 10;
                        break;
                    case "2":
                        order.BoostedRank = "D";
                        price2 = 20;
                        break;
                    case "3":
                        order.BoostedRank = "D+";
                        price2 = 30;
                        break;
                    case "4":
                        order.BoostedRank = "C-";
                        price2 = 40;
                        break;
                    case "5":
                        order.BoostedRank = "C";
                        price2 = 50;
                        break;
                    case "6":
                        order.BoostedRank = "C+";
                        price2 = 50;
                        break;
                    case "7":
                        order.BoostedRank = "B-";
                        price2 = 100;
                        break;
                    case "8":
                        order.BoostedRank = "B";
                        price2 = 150;
                        break;
                    case "9":
                        order.BoostedRank = "B+";
                        price2 = 200;
                        break;
                    case "10":
                        order.BoostedRank = "A-";
                        price2 = 250;
                        break;
                    case "11":
                        order.BoostedRank = "A";
                        price2 = 300;
                        break;
                    case "12":
                        order.BoostedRank = "A+";
                        price2 = 350;
                        break;
                    case "13":
                        order.BoostedRank = "Rank G";
                        price2 = 400;
                        break;
                    default:
                        break;
                }

                
                order.Price = price1 + price2;

                order.Description ="From " + order.CurrentRank + " to " + order.BoostedRank + " on " + "ESEA";

                order.ApplicationUser = user;
                _db.Add(order);
                await _db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            return View(order);
        }
        
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<IActionResult> Faceit([Bind("Username,CurrentRank,BoostedRank")] Order order)
        {
            var user = _userManager.GetUserAsync(User).Result;
            if (user == null)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                var price1 = 0;
                var price2 = 0;
                
                switch (order.CurrentRank)
                {
                    case "1":
                        order.CurrentRank = "Level 1";
                        price1 = 200;
                        break;
                    case "2":
                        order.CurrentRank = "Level 2";
                        price1 = 190;
                        break;
                    case "3":
                        order.CurrentRank = "Level 3";
                        price1 = 180;
                        break;
                    case "4":
                        order.CurrentRank = "Level 4";
                        price1 = 170;
                        break;
                    case "5":
                        order.CurrentRank = "Level 5";
                        price1 = 160;
                        break;
                    case "6":
                        order.CurrentRank = "Level 6";
                        price1 = 150;
                        break;
                    case "7":
                        order.CurrentRank = "Level 7";
                        price1 = 140;
                        break;
                    case "8":
                        order.CurrentRank = "Level 8";
                        price1 = 130;
                        break;
                    case "9":
                        order.CurrentRank = "Level 9";
                        price1 = 120;
                        break;
                    case "10":
                        order.CurrentRank = "Level 10";
                        price1 = 110;
                        break;
                    default:
                        break;
                }

                switch (order.BoostedRank)
                {
                    case "1":
                        order.BoostedRank = "Level 1";
                        price2 = 10;
                        break;
                    case "2":
                        order.BoostedRank = "Level 2";
                        price2 = 20;
                        break;
                    case "3":
                        order.BoostedRank = "Level 3";
                        price2 = 30;
                        break;
                    case "4":
                        order.BoostedRank = "Level 4";
                        price2 = 40;
                        break;
                    case "5":
                        order.BoostedRank = "Level 5";
                        price2 = 50;
                        break;
                    case "6":
                        order.BoostedRank = "Level 6";
                        price2 = 50;
                        break;
                    case "7":
                        order.BoostedRank = "Level 7";
                        price2 = 100;
                        break;
                    case "8":
                        order.BoostedRank = "Level 8";
                        price2 = 150;
                        break;
                    case "9":
                        order.BoostedRank = "Level 9";
                        price2 = 200;
                        break;
                    case "10":
                        order.BoostedRank = "Level 10";
                        price2 = 250;
                        break;
                    default:
                        break;
                }

                
                order.Price = price1 + price2;

                order.Description ="From " + order.CurrentRank + " to " + order.BoostedRank + " on " + "Faceit";

                order.ApplicationUser = user;
                _db.Add(order);
                await _db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            return View(order);
        }
        
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<IActionResult> Wingman([Bind("Username,CurrentRank,BoostedRank")] Order order)
        {
            var user = _userManager.GetUserAsync(User).Result;
            if (user == null)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                var price1 = 0;
                var price2 = 0;
                
                switch (order.CurrentRank)
                {
                    case "1":
                        order.CurrentRank = "Silver I";
                        price1 = 200;
                        break;
                    case "2":
                        order.CurrentRank = "Silver II";
                        price1 = 190;
                        break;
                    case "3":
                        order.CurrentRank = "Silver III";
                        price1 = 180;
                        break;
                    case "4":
                        order.CurrentRank = "Silver IV";
                        price1 = 170;
                        break;
                    case "5":
                        order.CurrentRank = "Silver Elite";
                        price1 = 160;
                        break;
                    case "6":
                        order.CurrentRank = "Silver Elite Master";
                        price1 = 150;
                        break;
                    case "7":
                        order.CurrentRank = "Gold Nova I";
                        price1 = 140;
                        break;
                    case "8":
                        order.CurrentRank = "Gold Nova II";
                        price1 = 130;
                        break;
                    case "9":
                        order.CurrentRank = "Gold Nova III";
                        price1 = 120;
                        break;
                    case "10":
                        order.CurrentRank = "Gold Nova Master";
                        price1 = 110;
                        break;
                    case "11":
                        order.CurrentRank = "Master Guardian I";
                        price1 = 100;
                        break;
                    case "12":
                        order.CurrentRank = "Master Guardian II";
                        price1 = 60;
                        break;
                    case "13":
                        order.CurrentRank = "Master Guardian Elite";
                        price1 = 50;
                        break;
                    case "14":
                        order.CurrentRank = "Distinguished Master Guardian";
                        price1 = 45;
                        break;
                    case "15":
                        order.CurrentRank = "Legendary Eagle";
                        price1 = 40;
                        break;
                    case "16":
                        order.CurrentRank = "Legendary Eagle Master";
                        price1 = 35;
                        break;
                    case "17":
                        order.CurrentRank = "Supreme Master First Class";
                        price1 = 30;
                        break;
                    case "18":
                        order.CurrentRank = "Global Elite";
                        price1 = 25;
                        break;
                    default:
                        break;
                }

                switch (order.BoostedRank)
                {
                    case "1":
                        order.BoostedRank = "Silver I";
                        price2 = 10;
                        break;
                    case "2":
                        order.BoostedRank = "Silver II";
                        price2 = 20;
                        break;
                    case "3":
                        order.BoostedRank = "Silver III";
                        price2 = 30;
                        break;
                    case "4":
                        order.BoostedRank = "Silver IV";
                        price2 = 40;
                        break;
                    case "5":
                        order.BoostedRank = "Silver Elite";
                        price2 = 50;
                        break;
                    case "6":
                        order.BoostedRank = "Silver Elite Master";
                        price2 = 50;
                        break;
                    case "7":
                        order.BoostedRank = "Gold Nova I";
                        price2 = 100;
                        break;
                    case "8":
                        order.BoostedRank = "Gold Nova II";
                        price2 = 150;
                        break;
                    case "9":
                        order.BoostedRank = "Gold Nova III";
                        price2 = 200;
                        break;
                    case "10":
                        order.BoostedRank = "Gold Nova Master";
                        price2 = 250;
                        break;
                    case "11":
                        order.BoostedRank = "Master Guardian I";
                        price2 = 300;
                        break;
                    case "12":
                        order.BoostedRank = "Master Guardian II";
                        price2 = 350;
                        break;
                    case "13":
                        order.BoostedRank = "Master Guardian Elite";
                        price2 = 400;
                        break;
                    case "14":
                        order.BoostedRank = "Distinguished Master Guardian";
                        price2 = 450;
                        break;
                    case "15":
                        order.BoostedRank = "Legendary Eagle";
                        price2 = 500;
                        break;
                    case "16":
                        order.BoostedRank = "Legendary Eagle Master";
                        price2 = 550;
                        break;
                    case "17":
                        order.BoostedRank = "Supreme Master First Class";
                        price2 = 600;
                        break;
                    case "18":
                        order.BoostedRank = "Global Elite";
                        price2 = 800;
                        break;
                    default:
                        break;
                }

                
                order.Price = price1 + price2;

                order.Description ="From " + order.CurrentRank + " to " + order.BoostedRank + " on " + "Wingman";

                order.ApplicationUser = user;
                _db.Add(order);
                await _db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            return View(order);
        }
        
    }
}