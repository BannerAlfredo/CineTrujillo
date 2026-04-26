namespace CineTrujilloAPI.DTOs
{
    public class CompraDto
    {
        public int IdUsuario { get; set; }

        public int IdFuncion { get; set; }

        public List<int> AsientosIds { get; set; }

        public decimal PrecioUnitario { get; set; }
    }

    public class DetalleCompraDto
    {
        public int IdAsiento { get; set; }
        public string Numero { get; set; }
        public decimal Precio { get; set; }
    }
}
