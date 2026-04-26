using CineTrujilloWeb.Models;
using CineTrujilloWeb.Services;
using Microsoft.AspNetCore.Mvc;

namespace CineTrujilloWeb.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly ApiService _api;

        public UsuarioController(ApiService api)
        {
            _api = api;
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(UsuarioLoginModel model)
        {
            var result = await _api.Login(model);

            if (result.Contains("Unauthorized"))
            {
                ViewBag.Error = "Credenciales incorrectas";
                return View();
            }

            return RedirectToAction("Cartelera", "Home");
        }

        // REGISTER (GET)
        public IActionResult Register()
        {
            return View();
        }

        // REGISTER (POST)
        [HttpPost]
        public async Task<IActionResult> Register(UsuarioRegisterModel model)
        {
            var result = await _api.Register(model);

            if (result.Contains("error") || result.Contains("Error"))
            {
                ViewBag.Error = "No se pudo registrar el usuario";
                return View();
            }

            return RedirectToAction("Login");
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login", "Usuario");
        }
    }
}
