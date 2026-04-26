using System.ComponentModel.DataAnnotations;

namespace CineTrujilloAPI.Models
{
    public class Asiento
    {
        [Key]
        public int IdAsiento { get; set; }
        public int IdFuncion { get; set; }
        public string Numero { get; set; }
        public string Estado { get; set; }
    }
}
