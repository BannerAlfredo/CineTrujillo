using System.ComponentModel.DataAnnotations;

namespace CineTrujilloAPI.Models
{
    public class DetalleCompra
    {
        [Key]
        public int IdDetalle { get; set; }
        public int IdCompra { get; set; }
        public int IdAsiento { get; set; }
        public decimal Precio { get; set; }
    }
}
