namespace CineTrujilloWeb.Models
{
    public class CompraDto
    {
        public int IdUsuario { get; set; }
        public List<int> AsientosIds { get; set; }
        public decimal PrecioUnitario { get; set; }
    }
}