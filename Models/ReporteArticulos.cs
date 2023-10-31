namespace BackProyTesis.Models
{
    public class ReporteArticulos
    {
        public string ANIO { get; set; } = null!;
        public string ART_CODIGO { get; set; } = null!;
        public string ART_NOMBRE { get; set; } = null!;
        public decimal EXISTENCIA { get; set; } = 0!;
        public string GRUPO { get; set; } = null!;
        public decimal ART_PRECIOSIVA { get; set; } = 0!;
        public decimal ART_PRECIOCIVA { get; set; } = 0!;
    }
}
