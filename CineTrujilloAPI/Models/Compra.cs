using System.ComponentModel.DataAnnotations;

namespace CineTrujilloAPI.Models
{
    public class Compra
    {
        [Key]
        public int IdCompra { get; set; }
        public int IdUsuario { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Total { get; set; }
        public string Estado { get; set; }
    }
}
