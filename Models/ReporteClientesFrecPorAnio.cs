namespace BackProyTesis.Models
{
    public class ReporteClientesFrecPorAnio
    {
        public string ANIO { get; set; } = null!;
        public string CLI_CODIGO { get; set; } = null!;
        public string CLI_NOMBRE { get; set; } = null!;
        public int NUMERO_DE_FACTURAS { get; set; } = 0!;
        public double TOTAL_FACTURAS { get; set; } = 0!;
    }
}
