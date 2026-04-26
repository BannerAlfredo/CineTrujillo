using CineTrujilloAPI.Data;
using CineTrujilloAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace CineTrujilloAPI.Services
{
    public class PeliculaService
    {
        private readonly CineDbContext _context;

        public PeliculaService(CineDbContext context)
        {
            _context = context;
        }

        public async Task<List<Pelicula>> GetAll()
        {
            return await _context.Peliculas.ToListAsync();
        }

        public async Task<Pelicula?> GetById(int id)
        {
            return await _context.Peliculas.FindAsync(id);
        }

        public async Task<Pelicula> Create(Pelicula pelicula)
        {
            _context.Peliculas.Add(pelicula);
            await _context.SaveChangesAsync();
            return pelicula;
        }

        public async Task<bool> Update(int id, Pelicula data)
        {
            var pelicula = await _context.Peliculas.FindAsync(id);
            if (pelicula == null) return false;

            pelicula.Titulo = data.Titulo;
            pelicula.Sinopsis = data.Sinopsis;
            pelicula.Genero = data.Genero;
            pelicula.Duracion = data.Duracion;
            pelicula.Clasificacion = data.Clasificacion;
            pelicula.ImagenUrl = data.ImagenUrl;

            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> Delete(int id)
        {
            var pelicula = await _context.Peliculas.FindAsync(id);
            if (pelicula == null) return false;

            _context.Peliculas.Remove(pelicula);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
