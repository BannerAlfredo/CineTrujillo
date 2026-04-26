using CineTrujilloAPI.DTOs;
using CineTrujilloAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace CineTrujilloAPI.Data
{
    public class CineDbContext : DbContext
    {
        public CineDbContext(DbContextOptions<CineDbContext> options)
    : base(options) { }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Pelicula> Peliculas { get; set; }
        public DbSet<Funcion> Funciones { get; set; }
        public DbSet<Asiento> Asientos { get; set; }
        public DbSet<Compra> Compras { get; set; }
        public DbSet<DetalleCompra> DetalleCompras { get; set; }

        internal async Task<string> ProcesarCompra(CompraDto dto)
        {
            throw new NotImplementedException();
        }
    }
}
