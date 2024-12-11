using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication1.Controllers
{
    [Route("api/vinyls")]
    [ApiController]
    public class VinylsController : ControllerBase
    {
        // GET: api/<VinylsController>
        [HttpGet]
        public IActionResult Get()
        {
            ProjektDbContext _context = new ProjektDbContext();
            
            var x = (from i in _context.Vinyls select i).ToList();
            return Ok(x);
        }

        // GET api/<VinylsController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            ProjektDbContext _context = new ProjektDbContext();
            var x = (from i in _context.Vinyls where i.VinylId == id select i).FirstOrDefault();
            if (x is null)
            {
                return NotFound();
            };
            return Ok(x);
        }

        // POST api/<VinylsController>
        [HttpPost("addVinyl/{title}/{artist}/{genre}/{value}")]
        public IActionResult AddVinyl(string title, string artist, string genre, decimal value, int? year=null, string? description=null)
        {
            ProjektDbContext _context = new ProjektDbContext();
            var newVinyl = new Vinyl
            {
                Title = title,
                Artist = artist,
                Genre = genre,
                Year = year,
                Description = description
            };
            _context.Vinyls.Add(newVinyl);
            _context.SaveChanges();
            return Ok(new { Message = "Sikeres hozzáadás" });

        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            ProjektDbContext _context = new ProjektDbContext();
            var x = (from i in _context.Vinyls where i.VinylId == id select i).FirstOrDefault();
            if (x is null)
            {
                return NotFound(new { Message = "Nincs ilyen ID-val felhasználó!" });
            };
            _context.Vinyls.Remove(x);
            _context.SaveChanges();
            return Ok(new { Message = "Sikeres törlés" });
        }
    }
}
