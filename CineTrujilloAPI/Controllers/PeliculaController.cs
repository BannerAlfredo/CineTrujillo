using CineTrujilloAPI.Data;
using CineTrujilloAPI.DTOs;
using CineTrujilloAPI.Models;
using CineTrujilloAPI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CineTrujilloAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PeliculaController : ControllerBase
    {
        private readonly PeliculaService _service;

        public PeliculaController(PeliculaService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var peliculas = await _service.GetAll();

            var result = peliculas.Select(p => new PeliculaDto
            {
                IdPelicula = p.IdPelicula,
                Titulo = p.Titulo,
                Sinopsis = p.Sinopsis,
                Genero = p.Genero,
                Duracion = p.Duracion,
                Clasificacion = p.Clasificacion,
                ImagenUrl = p.ImagenUrl
            });

            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var p = await _service.GetById(id);
            if (p == null) return NotFound();

            var result = new PeliculaDto
            {
                IdPelicula = p.IdPelicula,
                Titulo = p.Titulo,
                Sinopsis = p.Sinopsis,
                Genero = p.Genero,
                Duracion = p.Duracion,
                Clasificacion = p.Clasificacion,
                ImagenUrl = p.ImagenUrl
            };

            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Create(PeliculaDto dto)
        {
            var pelicula = new Pelicula
            {
                Titulo = dto.Titulo,
                Sinopsis = dto.Sinopsis,
                Genero = dto.Genero,
                Duracion = dto.Duracion,
                Clasificacion = dto.Clasificacion,
                ImagenUrl = dto.ImagenUrl
            };

            var result = await _service.Create(pelicula);
            return Ok(result);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, PeliculaDto dto)
        {
            var data = new Pelicula
            {
                Titulo = dto.Titulo,
                Sinopsis = dto.Sinopsis,
                Genero = dto.Genero,
                Duracion = dto.Duracion,
                Clasificacion = dto.Clasificacion,
                ImagenUrl = dto.ImagenUrl
            };

            var updated = await _service.Update(id, data);
            if (!updated) return NotFound();

            return Ok("Actualizado correctamente");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var deleted = await _service.Delete(id);
            if (!deleted) return NotFound();

            return Ok("Eliminado correctamente");
        }
    }
}
