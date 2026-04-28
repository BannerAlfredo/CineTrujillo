namespace CineTrujilloAPI.DTOs
{
    public class CompraResponseDto
    {
        public int IdCompra { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Total { get; set; }
        public string Estado { get; set; }

        public List<string> Asientos { get; set; }
        public string Pelicula { get; set; }
        public string Sala { get; set; }
        public DateTime Horario { get; set; }
    }
}
