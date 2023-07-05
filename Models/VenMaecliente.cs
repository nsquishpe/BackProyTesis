using System;
using System.Collections.Generic;

namespace BackProyTesis.Models;

public partial class VenMaecliente
{
    public string Anio { get; set; } = null!;

    public string CliCodigo { get; set; } = null!;

    //public string? GruCodigo { get; set; }

    //public string? VenCodigo { get; set; }

    //public string CliNombrec { get; set; } = null!;

    public string CliNombre { get; set; } = null!;

    public string? CliTipoide { get; set; }

    //public string CliRucide { get; set; } = null!;

    public string? CliDireccion1 { get; set; }

    //public string? CliDireccion2 { get; set; }

    //public string? CliCodpostal { get; set; }

    public string? CliTelefono1 { get; set; }

    //public string? CliTelefono2 { get; set; }

    //public string? CliFax { get; set; }

    public string? CliCorreo { get; set; }

    //public string? CliContacto { get; set; }

    //public DateTime? CliFecing { get; set; }

    //public decimal? CliLimcredit { get; set; }

    //public decimal? CliDiacredit { get; set; }

    //public decimal? CliDescuento { get; set; }

    //public string? CliIva { get; set; }

    //public string? CliContribuyente { get; set; }

    //public string? CliLista { get; set; }

    //public string? ConCodigo1 { get; set; }

    //public string? ConCodigo2 { get; set; }

    //public string? CliZona { get; set; }

    //public string? CliObservacion { get; set; }

    public decimal? CliSaldo { get; set; }

    //public string? NomCodigo { get; set; }

    //public string? DepCodigo { get; set; }

    //public string? CliTipo { get; set; }

    //public string? CliProvincia { get; set; }

    //public string? CiuCodigo { get; set; }

    //public string? TcrCodigo { get; set; }

    //public string? CliTrfiva { get; set; }

    //public string? CliTrfretencion { get; set; }

    //public string? CbrCodigo { get; set; }

    //public string? CliEstado { get; set; }

    //public string? EncffaCodigo { get; set; }

    //public string? CliLinneg { get; set; }

    //public decimal? CliPorcedescuento { get; set; }

    //public decimal? CliValorrecargo { get; set; }

    //public decimal? CliPorcerecargo { get; set; }

    //public DateTime? CliFechaultpag { get; set; }

    //public string? CliCodseguridad { get; set; }

    //public bool? CliFlag { get; set; }

    //public string? CliCodiformpago1 { get; set; }

    //public string? CliCodiformpago2 { get; set; }

    public virtual ICollection<VenEncfac> VenEncfacs { get; set; } = new List<VenEncfac>();
}
