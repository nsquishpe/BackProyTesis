namespace BackProyTesis.Models
{
    public class ReporteArticulos
    {
        public string ANIO { get; set; } = null!;
        public string ART_CODIGO { get; set; } = null!;
        public string ART_NOMBRE { get; set; } = null!;
        public double? EXISTENCIA { get; set; } = 0;
        public string GRUPO { get; set; } = null!;
        public double? ART_PRECIOSIVA { get; set; } = 0;
        public double? ART_PRECIOCIVA { get; set; } = 0;
    }
}
