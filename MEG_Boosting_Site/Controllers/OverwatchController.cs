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
    public class OverwatchController : Controller
    {
        private readonly ApplicationDbContext _db;
        private readonly UserManager<ApplicationUser> _userManager;

        public OverwatchController(ApplicationDbContext db, UserManager<ApplicationUser> userManager)
        {
            _db = db;
            _userManager = userManager;
        }
        
        
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
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<IActionResult> Ranked([Bind("Username,CurrentRank,BoostedRank,BoostedTier,Platform")] Order order)
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
                double platformprice = 0;
                double roleprice = 0;
                double totprice = 0;
                
                switch (order.CurrentRank)
                {
                    case "1":
                        order.CurrentRank = "Bronze";
                        price1 = 100;
                        break;
                    case "2":
                        order.CurrentRank = "Silver";
                        price1 = 90;
                        break;
                    case "3":
                        order.CurrentRank = "Gold";
                        price1 = 80;
                        break;
                    case "4":
                        order.CurrentRank = "Platinum";
                        price1 = 70;
                        break;
                    case "5":
                        order.CurrentRank = "Diamond";
                        price1 = 40;
                        break;
                    case "6":
                        order.CurrentRank = "Master";
                        price1 = 30;
                        break;
                    case "7":
                        order.CurrentRank = "Grandmaster";
                        price1 = 20;
                        break;
                    default:
                        break;
                }

                switch (order.BoostedRank)
                {
                    case "1":
                        order.BoostedRank = "Bronze";
                        price2 = 20;
                        break;
                    case "2":
                        order.BoostedRank = "Silver";
                        price2 = 35;
                        break;
                    case "3":
                        order.BoostedRank = "Gold";
                        price2 = 65;
                        break;
                    case "4":
                        order.BoostedRank = "Platinum";
                        price2 = 140;
                        break;
                    case "5":
                        order.BoostedRank = "Diamond";
                        price2 = 265;
                        break;
                    case "6":
                        order.BoostedRank = "Master";
                        price2 = 510;
                        break;
                    case "7":
                        order.BoostedRank = "Grandmaster";
                        price2 = 975;
                        break;
                    default:
                        break;
                }

                switch (order.BoostedTier)
                {
                    case "1":
                        order.BoostedTier = "Tank";
                        roleprice = 1;
                        break;
                    case "2":
                        order.BoostedTier = "Support";
                        roleprice = 1;
                        break;
                    case "3":
                        order.BoostedTier = "DPS";
                        roleprice = 1.2;
                        break;
                    case "4":
                        order.BoostedTier = "Open Queue";
                        roleprice = 0.8;
                        break;
                    default:
                        break;
                }
                switch (order.Platform)
                {
                    case "1":
                        order.Platform = "Bnet";
                        platformprice = 1;
                        break;
                    case "2":
                        order.Platform = "Xbox";
                        platformprice = 1.2;
                        break;
                    case "3":
                        order.Platform = "PSN";
                        platformprice = 1.2;
                        break;
                    default:
                        break;
                }

                totprice = price1 + price2 * platformprice * roleprice;
                totprice = Math.Ceiling(totprice);
                order.Price = totprice;

                order.Description ="From " + order.CurrentRank + " to " + order.BoostedRank + " as "+ order.BoostedTier + " on " + order.Platform;

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
        public async Task<IActionResult> Levling([Bind("Username,CurrentRank,Platform")] Order order)
        {
            var user = _userManager.GetUserAsync(User).Result;
            if (user == null)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                var price1 = 0;
                double platformprice = 0;
                
                switch (order.CurrentRank)
                {
                    case "1":
                        order.CurrentRank = "1-10 Lvls";
                        price1 = 15;
                        break;
                    case "2":
                        order.CurrentRank = "20-30 Lvls";
                        price1 = 25;
                        break;
                    case "3":
                        order.CurrentRank = "30-50 Lvls";
                        price1 = 45;
                        break;
                    case "4":
                        order.CurrentRank = "50-75 Lvls";
                        price1 = 75;
                        break;
                    case "5":
                        order.CurrentRank = "75-100 Lvls";
                        price1 = 115;
                        break;
                    default:
                        break;
                }

                switch (order.Platform)
                {
                    case "1":
                        order.Platform = "Bnet";
                        platformprice = 1;
                        break;
                    case "2":
                        order.Platform = "Xbox";
                        platformprice = 1.2;
                        break;
                    case "3":
                        order.Platform = "PSN";
                        platformprice = 1.2;
                        break;
                    default:
                        break;
                }
                
                order.Price = price1 * platformprice;

                order.Description = order.CurrentRank + " on " + order.Platform;

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
        public async Task<IActionResult> Coaching([Bind("Username,CurrentRank,Platform")] Order order)
        {
            var user = _userManager.GetUserAsync(User).Result;
            if (user == null)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                var price1 = 0;
                double platformprice = 0;
                
                switch (order.CurrentRank)
                {
                    case "1":
                        order.CurrentRank = "1 Hours";
                        price1 = 20;
                        break;
                    case "2":
                        order.CurrentRank = "2 Hours";
                        price1 = 35;
                        break;
                    case "3":
                        order.CurrentRank = "5 Hours";
                        price1 = 65;
                        break;
                    case "4":
                        order.CurrentRank = "10 Hours";
                        price1 = 140;
                        break;
                    case "5":
                        order.CurrentRank = "25 Hours";
                        price1 = 265;
                        break;
                    case "6":
                        order.CurrentRank = "50 Hours";
                        price1 = 510;
                        break;
                    case "7":
                        order.CurrentRank = "100 Hours";
                        price1 = 975;
                        break;
                    default:
                        break;
                }

                switch (order.Platform)
                {
                    case "1":
                        order.Platform = "Bnet";
                        platformprice = 1;
                        break;
                    case "2":
                        order.Platform = "Xbox";
                        platformprice = 1.2;
                        break;
                    case "3":
                        order.Platform = "PSN";
                        platformprice = 1.2;
                        break;
                    default:
                        break;
                }
                
                order.Price = price1 * platformprice;

                order.Description = order.CurrentRank + " of coaching " + " on " + order.Platform;

                order.ApplicationUser = user;
                _db.Add(order);
                await _db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            return View(order);
        }
    }
}