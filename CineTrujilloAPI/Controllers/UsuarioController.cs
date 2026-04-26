using CineTrujilloAPI.DTOs;
using CineTrujilloAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace CineTrujilloAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsuarioController : ControllerBase
    {
        private readonly UsuarioService _service;

        public UsuarioController(UsuarioService service)
        {
            _service = service;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginDto dto)
        {
            var user = await _service.Login(dto);
            if (user == null) return Unauthorized();
            return Ok(user);
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register(RegistroDto dto)
        {
            return Ok(await _service.Register(dto));
        }
    }
}
