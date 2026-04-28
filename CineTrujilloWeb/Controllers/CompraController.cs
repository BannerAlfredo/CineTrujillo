using CineTrujilloWeb.Services;
using Microsoft.AspNetCore.Mvc;

public class CompraController : Controller
{
    private readonly ApiService _api;

    public CompraController(ApiService api)
    {
        _api = api;
    }

    // PASO 1: FUNCIONES
    public async Task<IActionResult> Funciones(int id)
    {
        var data = await _api.GetFunciones(id);
        return View(data);
    }

    // PASO 2: ASIENTOS
    public async Task<IActionResult> Asientos(int idFuncion)
    {
        var data = await _api.GetAsientos(idFuncion);
        ViewBag.IdFuncion = idFuncion;
        return View(data);
    }

    // PASO 3: CONFIRMAR
    [HttpPost]
    public async Task<IActionResult> Comprar(int idFuncion, List<int> asientos)
    {
        var dto = new
        {
            idUsuario = 1,
            idFuncion = idFuncion,
            asientosIds = asientos,
            precioUnitario = 15
        };

        var result = await _api.Comprar(dto);

        TempData["msg"] = result;

        return RedirectToAction("Cartelera", "Home");
    }
    public async Task<IActionResult> MisCompras()
    {
        int idUsuario = int.Parse(HttpContext.Session.GetString("IdUsuario"));

        var compras = await _api.GetMisCompras(idUsuario);

        return View(compras);
    }
}