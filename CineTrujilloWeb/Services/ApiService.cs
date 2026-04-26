using CineTrujilloWeb.Models;

namespace CineTrujilloWeb.Services
{
    public class ApiService
    {
        private readonly HttpClient _http;

        public ApiService(HttpClient http)
        {
            _http = http;
        }

        // LOGIN
        public async Task<string> Login(object data)
        {
            var response = await _http.PostAsJsonAsync("usuario/login", data);
            return await response.Content.ReadAsStringAsync();
        }

        // REGISTER
        public async Task<string> Register(object data)
        {
            var response = await _http.PostAsJsonAsync("usuario/register", data);
            return await response.Content.ReadAsStringAsync();
        }

        // PELICULAS
        public async Task<List<Pelicula>> GetPeliculas()
        {
            return await _http.GetFromJsonAsync<List<Pelicula>>("pelicula");
        }

        // FUNCIONES POR PELICULA
        public async Task<List<Funcion>> GetFunciones(int idPelicula)
        {
            return await _http.GetFromJsonAsync<List<Funcion>>($"Funciones/pelicula/{idPelicula}");
        }

        // ASIENTOS POR FUNCION
        public async Task<List<Asiento>> GetAsientos(int idFuncion)
        {
            return await _http.GetFromJsonAsync<List<Asiento>>($"Asientos/funcion/{idFuncion}");
        }

        //  COMPRAR
        public async Task<string> Comprar(object data)
        {
            var response = await _http.PostAsJsonAsync("Compras", data);
            return await response.Content.ReadAsStringAsync();
        }
    }
}