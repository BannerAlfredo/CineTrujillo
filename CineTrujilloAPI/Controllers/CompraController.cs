using CineTrujilloAPI.Data;
using CineTrujilloAPI.DTOs;
using CineTrujilloAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace CineTrujilloAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ComprasController : ControllerBase
    {
        private readonly CompraService _service;

        public ComprasController(CompraService service)
        {
            _service = service;
        }

        [HttpPost]
        public async Task<IActionResult> Comprar([FromBody] CompraDto dto)
        {
            if (dto == null || dto.AsientosIds == null || !dto.AsientosIds.Any())
                return BadRequest("Datos inválidos");

            var result = await _service.ProcesarCompra(dto);

            if (result != "Compra exitosa")
                return BadRequest(result);

            return Ok(new { mensaje = result });
        }
        [HttpGet("usuario/{idUsuario}")]
        public async Task<IActionResult> ObtenerPorUsuario(int idUsuario)
        {
            var data = await _service.ObtenerCompras(idUsuario);
            return Ok(data);
        }
    }
}
