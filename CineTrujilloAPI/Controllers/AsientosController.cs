using CineTrujilloAPI.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CineTrujilloAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AsientosController : ControllerBase
    {
        private readonly CineDbContext _context;

        public AsientosController(CineDbContext context)
        {
            _context = context;
        }

        [HttpGet("funcion/{id}")]
        public async Task<IActionResult> GetByFuncion(int id)
        {
            var data = await _context.Asientos
                .Where(a => a.IdFuncion == id)
                .ToListAsync();

            return Ok(data);
        }
    }
}