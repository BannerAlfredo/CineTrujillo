using CineTrujilloAPI.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CineTrujilloAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FuncionesController : ControllerBase
    {
        private readonly CineDbContext _context;

        public FuncionesController(CineDbContext context)
        {
            _context = context;
        }

        [HttpGet("pelicula/{id}")]
        public async Task<IActionResult> GetByPelicula(int id)
        {
            var data = await _context.Funciones
                .Where(f => f.IdPelicula == id)
                .ToListAsync();

            return Ok(data);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var funcion = await _context.Funciones.FindAsync(id);

            if (funcion == null)
                return NotFound();

            return Ok(funcion);
        }
    }
}
