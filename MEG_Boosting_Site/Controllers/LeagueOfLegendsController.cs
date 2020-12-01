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
    public class LeagueOfLegendsController : Controller
    {
        private readonly ApplicationDbContext _db;
        private readonly UserManager<ApplicationUser> _userManager;

        public LeagueOfLegendsController(ApplicationDbContext db, UserManager<ApplicationUser> userManager)
        {
            _db = db;
            _userManager = userManager;
        }
        
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
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<IActionResult> Rankedboost([Bind("Username,Server,CurrentRank,CurrentTier,BoostedRank,BoostedTier")] Order order)
        {
            var user = _userManager.GetUserAsync(User).Result;
            if (user == null)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                var playerRank = order.CurrentRank;
                var boostRank = order.BoostedRank;
                var playerTier = order.CurrentTier;
                var boostTier = order.BoostedTier;
                var playerRankPrice = 0;
                var boostRankPrice = 0;
                var playerTierPrice = 0;
                var boostTierPrice = 0;
                if (playerTier != null)
                {
                    switch (playerTier)
                    {
                        case "I":
                            playerTierPrice = 15;
                            break;
                        case "II":
                            playerTierPrice = 10;
                            break;
                        case "III":
                            playerTierPrice = 5;
                            break;
                        case "IV":
                            playerTierPrice = 0;
                            break;
                        default:
                            playerTierPrice = 0;
                            break;
                    }
                }
                if (boostTier != null)
                {
                    switch (boostTier)
                    {
                        case "I":
                            boostTierPrice = 15;
                            break;
                        case "II":
                            boostTierPrice = 10;
                            break;
                        case "III":
                            boostTierPrice = 5;
                            break;
                        case "IV":
                            boostTierPrice = 0;
                            break;
                        default:
                            boostTierPrice = 0;
                            break;
                    }
                }
                switch (playerRank)
                {
                    case "Iron":
                        playerRankPrice = 100;
                        break;
                    case "Bronze":
                        playerRankPrice = 80;
                        break;
                    case "Silver":
                        playerRankPrice = 60;
                        break;
                    case "Gold":
                        playerRankPrice = 40;
                        break;
                    case "Platinum":
                        playerRankPrice = 30;
                        break;
                    case "Diamond":
                        playerRankPrice = 20;
                        break;
                    case "Master":
                        playerRankPrice = 15;
                        break;
                    case "Grandmaster":
                        playerRankPrice = 10;
                        break;
                    case "Challenger":
                        playerRankPrice = 5;
                        break;
                }
                switch (boostRank)
                {
                    case "Iron":
                        boostRankPrice = 10;
                        break;
                    case "Bronze":
                        boostRankPrice = 15;
                        break;
                    case "Silver":
                        boostRankPrice = 20;
                        break;
                    case "Gold":
                        boostRankPrice = 25;
                        break;
                    case "Platinum":
                        boostRankPrice = 30;
                        break;
                    case "Diamond":
                        boostRankPrice = 35;
                        break;
                    case "Master":
                        boostRankPrice = 100;
                        break;
                    case "Grandmaster":
                        boostRankPrice = 200;
                        break;
                    case "Challenger":
                        boostRankPrice = 500;
                        break;
                }
                order.Price = playerRankPrice + boostRankPrice - playerTierPrice + boostTierPrice;
                
                order.ApplicationUser = user;
                _db.Add(order);
                await _db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            return View(order);
        }
    }
}