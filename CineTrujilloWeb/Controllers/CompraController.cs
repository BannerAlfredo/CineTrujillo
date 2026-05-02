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
        var asientos = await _api.GetAsientos(idFuncion);

        var funcion = await _api.GetFuncion(idFuncion);
        var pelicula = await _api.GetPelicula(funcion.IdPelicula);

        ViewBag.IdFuncion = idFuncion;
        ViewBag.Pelicula = pelicula.Titulo;
        ViewBag.Imagen = pelicula.ImagenUrl;
        ViewBag.Sala = funcion.Sala;
        ViewBag.Hora = funcion.Horario.ToString("HH:mm");
        ViewBag.Fecha = funcion.Horario.ToString("dd/MM/yyyy");

        return View(asientos);
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

    [HttpPost]
    public async Task<IActionResult> Confirmar(int idFuncion, List<int> asientos)
    {
        if (asientos == null || !asientos.Any())
        {
            TempData["error"] = "Debes seleccionar al menos un asiento";
            return RedirectToAction("Asientos", new { idFuncion });
        }

        var correo = HttpContext.Session.GetString("Correo");
        var funcion = await _api.GetFuncion(idFuncion);
        var pelicula = await _api.GetPelicula(funcion.IdPelicula);
        var todosAsientos = await _api.GetAsientos(idFuncion);

        var seleccionados = todosAsientos
            .Where(a => asientos.Contains(a.IdAsiento))
            .ToList();

        // ✅ SEPARAR
        ViewBag.AsientosIds = seleccionados.Select(a => a.IdAsiento).ToList();
        ViewBag.AsientosNumeros = seleccionados.Select(a => a.Numero).ToList();

        ViewBag.IdFuncion = idFuncion;
        ViewBag.Total = asientos.Count * 15;
        ViewBag.Correo = correo;

        ViewBag.Pelicula = pelicula.Titulo;
        ViewBag.Sala = funcion?.Sala;
        ViewBag.Hora = funcion?.Horario.ToString("HH:mm");

        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Finalizar(int idFuncion, List<int> asientos, string password)
    {
        if (string.IsNullOrEmpty(password))
        {
            TempData["Error"] = "Debes ingresar tu contraseña";
            return RedirectToAction("Cartelera", "Home");
        }

        int idUsuario = int.Parse(HttpContext.Session.GetString("IdUsuario"));

        var dto = new
        {
            idUsuario = idUsuario,
            idFuncion = idFuncion,
            asientosIds = asientos,
            precioUnitario = 15
        };

        var result = await _api.Comprar(dto);

        if (!result.Contains("exitosa"))
        {
            TempData["Error"] = result;
            return RedirectToAction("Asientos", new { idFuncion });
        }

        TempData["msg"] = result;
        return RedirectToAction("MisCompras");
    }

    public async Task<IActionResult> MisCompras()
    {
        int idUsuario = int.Parse(HttpContext.Session.GetString("IdUsuario"));

        var compras = await _api.GetMisCompras(idUsuario);

        return View(compras);
    }
}