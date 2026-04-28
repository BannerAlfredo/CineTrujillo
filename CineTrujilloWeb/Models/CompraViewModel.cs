namespace CineTrujilloWeb.Models
{
    public class CompraViewModel
    {
        public int IdCompra { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Total { get; set; }
        public string Estado { get; set; }
        public List<string> Asientos { get; set; }
    }
}
