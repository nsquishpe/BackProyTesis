namespace BackProyTesis.Models
{
    public class ReporteVentas
    {
        public string CLI_CODIGO { get; set; } = null!;
        public string CLI_NOMBRE { get; set; } = null!;
        public DateTime ENCFAC_FECHAEMISION { get; set; }
        public string ENCFAC_ESTADO { get; set; } = null!;
        public string ENCFAC_REFERENCIA { get; set; } = null!;
        public double SUBTOTAL { get; set; } = 0!;
        public double IVA { get; set; } = 0!;
        public double TOTAL { get; set; } = 0!;
    }
}
