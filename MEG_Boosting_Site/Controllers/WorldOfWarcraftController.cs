using System.Linq;
using System.Threading.Tasks;
using MEG_Boosting_Site.Data;
using MEG_Boosting_Site.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MEG_Boosting_Site.Controllers
{
    public class WorldOfWarcraftController : Controller
    {
        private readonly ApplicationDbContext _db;
        private readonly UserManager<ApplicationUser> _userManager;

        public WorldOfWarcraftController(ApplicationDbContext db, UserManager<ApplicationUser> userManager)
        {
            _db = db;
            _userManager = userManager;
        }

        // GET
        [HttpGet]
        public async Task<ActionResult> ClassicIndex()
        {
            var WoWClassic = _db.Products.Where(n => n.Service.Equals("WoWClassic")).ToListAsync();
            return View(await WoWClassic);
        }
        
        // GET
        [HttpGet]
        public async Task<IActionResult> RetailIndex()
        {
            var WoWRetail = _db.Products.Where(s => s.Service.Equals("WoWRetail")).ToListAsync();
            return View(await WoWRetail);
        }

        [HttpGet]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            
            var WoWBoost = await _db.Products.FirstOrDefaultAsync(i => i.Id == id);

            if (WoWBoost == null)
            {
                return NotFound();
            }
            
            return View(WoWBoost);
        }
    }
}