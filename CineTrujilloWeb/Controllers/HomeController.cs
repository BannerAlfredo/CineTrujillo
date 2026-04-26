using CineTrujilloWeb.Services;
using Microsoft.AspNetCore.Mvc;

namespace CineTrujilloWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApiService _api;

        public HomeController(ApiService api)
        {
            _api = api;
        }

        public async Task<IActionResult> Cartelera()
        {
            var peliculas = await _api.GetPeliculas();
            return View(peliculas);
        }

    }
}
