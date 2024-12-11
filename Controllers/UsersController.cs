using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.Metrics;
using System.Linq.Expressions;
using WebApplication1.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication1.Controllers
{
    [Route("api/users")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        // GET: api/<UsersController>
        [HttpGet]
        public IActionResult Get()
        {
            ProjektDbContext _context = new ProjektDbContext();
            var x = (from i in _context.Users select i).ToList();
            return Ok(x);
        }

        // GET api/<UsersController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            ProjektDbContext _context = new ProjektDbContext();
            var x = (from i in _context.Users where i.UserId==id select i).FirstOrDefault();
            if(x is null)
            {
                return NotFound();
            };
            return Ok(x);
        }

        // POST api/<UsersController>
        [HttpPost("createUser/{username}/{email}")]
        public IActionResult CreateUser(string username, string email)
        {
            ProjektDbContext _context = new ProjektDbContext();
            var newUser = new User
            {
                Username = username,
                Email = email
            };
            _context.Users.Add(newUser);
            _context.SaveChanges();
            return Ok(new {Message="Sikeres hozzáadás"});

        }

        [HttpPost("updateUsername/{id}/{newusername}")]
        public IActionResult Updateusername(int id, string newusername)
        {
            ProjektDbContext _context = new ProjektDbContext();
            var x = (from i in _context.Users where i.UserId == id select i).FirstOrDefault();
            if (x is null)
            {
                return NotFound(new { Message = "Nincs ilyen ID-val felhasználó!" });
            };
            x.Username = newusername;
            _context.SaveChanges();
            return Ok(new { Message = "Sikeres módosítás" });

        }
 

        // DELETE api/<UsersController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            ProjektDbContext _context = new ProjektDbContext();
            var x = (from i in _context.Users where i.UserId == id select i).FirstOrDefault();
            if (x is null)
            {
                return NotFound(new { Message = "Nincs ilyen ID-val felhasználó!" });
            };
            _context.Users.Remove(x);
            _context.SaveChanges();
            return Ok(new {Message="Sikeres törlés"});
        }
    }
}
