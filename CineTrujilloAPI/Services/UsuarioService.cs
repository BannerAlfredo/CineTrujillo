using CineTrujilloAPI.Data;
using CineTrujilloAPI.DTOs;
using CineTrujilloAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace CineTrujilloAPI.Services
{
    public class UsuarioService
    {
        private readonly CineDbContext _context;

        public UsuarioService(CineDbContext context)
        {
            _context = context;
        }

        public async Task<Usuario> Login(LoginDto dto)
        {
            return await _context.Usuarios
                .FirstOrDefaultAsync(u => u.Correo == dto.Correo && u.Password == dto.Password);
        }

        public async Task<Usuario> Register(RegistroDto dto)
        {
            var user = new Usuario
            {
                Nombre = dto.Nombre,
                Correo = dto.Correo,
                Password = dto.Password
            };

            _context.Usuarios.Add(user);
            await _context.SaveChangesAsync();

            return user;
        }
    }
}
