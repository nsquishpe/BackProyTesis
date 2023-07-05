using System;
using System.Collections.Generic;

namespace BackProyTesis.Models;

public partial class InvMaearticulo
{
    public string Anio { get; set; } = null!;

    public string ArtCodigo { get; set; } = null!;

    public string ComCodigo { get; set; } = null!;

    public string? GrupCodigo { get; set; }

    public string ArtNombre { get; set; } = null!;

    public string ArtNombrec { get; set; } = null!;

    public string? GrupCodigop { get; set; }

    public string? ArtTributaiva { get; set; }

    public string? ArtTributaice { get; set; }

    public string? ArtFechaing { get; set; }

    public string? ArtLaboratorio { get; set; }

    public string? ArtUbicacion { get; set; }

    public string? ArtMultiunidad { get; set; }

    public string? ArtUnidadventa { get; set; }

    public string? ArtUnidadcosteo { get; set; }

    public string? ArtCaduca { get; set; }

    public string? ArtCodigoalt1 { get; set; }

    public string? ArtCodigoalt2 { get; set; }

    public string? ArtCodigoalt3 { get; set; }

    public string? ArtCodigoalt4 { get; set; }

    public decimal? ArtLargo { get; set; }

    public decimal? ArtAltura { get; set; }

    public decimal? ArtAncho { get; set; }

    public decimal? ArtPeso { get; set; }

    public string? ArtCompuesto { get; set; }

    public decimal? ArtCantmin { get; set; }

    public decimal? ArtCantmax { get; set; }

    public string? ConCodigoact { get; set; }

    public string? ConCodigogas { get; set; }

    public string? ConCodigoing { get; set; }

    public string? ConCodigoord1 { get; set; }

    public string? ConCodigoord2 { get; set; }

    public string? ArtObservacion { get; set; }

    public string? ArtCodigoice { get; set; }

    public string? ArtMarca { get; set; }

    public string? ArtModelo { get; set; }

    public string? ArtSerie { get; set; }

    public decimal? ArtVolumen { get; set; }

    public string? PresentacionCodigo { get; set; }

    public decimal? ArtFactor { get; set; }

    public bool? ArtFlag { get; set; }

    public bool? ArtFormavta { get; set; }

    public decimal? ArtDescuento { get; set; }

    public string? ArtSerialflag { get; set; }

    public decimal? ArtDiasgarantia { get; set; }

    public decimal? ArtValorice { get; set; }

    public bool? ArtInactivo { get; set; }

    public string? BodCodigo { get; set; }

    public decimal? ArtSecbodtrans { get; set; }

    public string? VenCodigo { get; set; }

    public virtual ICollection<InvTrnkardex> InvTrnkardices { get; set; } = new List<InvTrnkardex>();
}
