using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GestionHotel.Apis.administration.controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class userApp_controller : ControllerBase
    {
        private readonly AppDbContext _context;

        public UserAPPController(AppDbContext context)
        {
            _context = context;
        }

        // GET: /UserAPP
        [HttpGet]
        public ActionResult<IEnumerable<UserAPP>> GetUserAPPs()
        {
            return _context.UserAPP.ToList();
        }

        // GET: /UserAPP/{id}
        [HttpGet("{id}")]
        public ActionResult<UserAPP> GetUserAPP(Guid id)
        {
            var userAPP = _context.UserAPP.Find(id);

            if (userAPP == null)
            {
                return NotFound();
            }

            return userAPP;
        }

        // POST: /UserAPP
        [HttpPost]
        public ActionResult<UserAPP> PostUserAPP(UserAPP userAPP)
        {
            _context.UserAPP.Add(userAPP);
            _context.SaveChanges();

            return CreatedAtAction(nameof(GetUserAPP), new { id = userAPP.Id }, userAPP);
        }

        // PUT: /UserAPP/{id}
        [HttpPut("{id}")]
        public IActionResult PutUserAPP(Guid id, UserAPP userAPP)
        {
            if (id != userAPP.Id)
            {
                return BadRequest();
            }

            _context.Entry(userAPP).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();

            return NoContent();
        }

        // DELETE: /UserAPP/{id}
        [HttpDelete("{id}")]
        public IActionResult DeleteUserAPP(Guid id)
        {
            var userAPP = _context.UserAPP.Find(id);

            if (userAPP == null)
            {
                return NotFound();
            }

            _context.UserAPP.Remove(userAPP);
            _context.SaveChanges();

            return NoContent();
        }
    }
}
