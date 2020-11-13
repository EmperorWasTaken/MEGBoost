using System.Linq;
using MEG_Boosting_Site.Data;
using MEG_Boosting_Site.Models;
using Microsoft.AspNetCore.Mvc;

namespace MEG_Boosting_Site.Controllers
{
    
    [Route("api/review")]
    [ApiController]
    public class ReviewApiController : ControllerBase
    {

        private readonly ApplicationDbContext _db;

        public ReviewApiController(ApplicationDbContext db)
        {
            _db = db;
        }


        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_db.Reviews.ToList());
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var review = _db.Products.Find(id);

            if (review == null)
            {
                return NotFound();
            }

            return Ok(review);
        }

        [HttpPost]
        public IActionResult Post(Review review)
        {
            if (review.Id != 0)
            {
                return BadRequest();
            }

            _db.Add(review);
            _db.SaveChanges();

            return CreatedAtAction(nameof(Get), new {id = review.Id}, review);
        }
    }
}