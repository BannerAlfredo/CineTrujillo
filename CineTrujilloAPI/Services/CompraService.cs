using CineTrujilloAPI.Data;
using CineTrujilloAPI.DTOs;
using CineTrujilloAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace CineTrujilloAPI.Services
{
    public class CompraService
    {
        private readonly CineDbContext _context;

        public CompraService(CineDbContext context)
        {
            _context = context;
        }

        public async Task<string> ProcesarCompra(CompraDto dto)
        {
            using var transaction = await _context.Database.BeginTransactionAsync();

            // 1. Obtener asientos de la función
            var asientos = await _context.Asientos
                .Where(a => dto.AsientosIds.Contains(a.IdAsiento)
                         && a.IdFuncion == dto.IdFuncion)
                .ToListAsync();

            // 2. Validar disponibilidad
            if (asientos.Count != dto.AsientosIds.Count)
                return "Asientos inválidos";

            if (asientos.Any(a => a.Estado == "Ocupado"))
                return "Uno o más asientos ya están ocupados";

            // 3. Marcar como ocupados
            foreach (var asiento in asientos)
            {
                asiento.Estado = "Ocupado";
            }

            // 4. Crear compra
            var total = dto.AsientosIds.Count * dto.PrecioUnitario;

            var compra = new Compra
            {
                IdUsuario = dto.IdUsuario,
                Fecha = DateTime.Now,
                Total = total,
                Estado = "Confirmada"
            };

            _context.Compras.Add(compra);
            await _context.SaveChangesAsync();

            // 5. Crear detalle de compra
            foreach (var asiento in asientos)
            {
                _context.DetalleCompras.Add(new DetalleCompra
                {
                    IdCompra = compra.IdCompra,
                    IdAsiento = asiento.IdAsiento,
                    Precio = dto.PrecioUnitario
                });
            }

            await _context.SaveChangesAsync();

            await transaction.CommitAsync();

            return "Compra exitosa";
             }
         }   
    }
