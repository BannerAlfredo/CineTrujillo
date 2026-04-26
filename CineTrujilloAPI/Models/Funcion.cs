using System.ComponentModel.DataAnnotations;

namespace CineTrujilloAPI.Models
{
    public class Funcion
    {
        [Key]
        public int IdFuncion { get; set; }
        public int IdPelicula { get; set; }
        public string Sala { get; set; }
        public DateTime Horario { get; set; }
    }
}
