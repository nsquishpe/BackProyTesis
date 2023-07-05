using System;
using System.Collections.Generic;

namespace BackProyTesis.Models;

public partial class InvTrnkardex
{
    public string Anio { get; set; } = null!;

    public string? Mes { get; set; }

    public string? Dia { get; set; }

    public string BodCodigo { get; set; } = null!;

    public string ArtCodigo { get; set; } = null!;

    public string ComCodigo { get; set; } = null!;

    public string TrnartNumero { get; set; } = null!;

    public DateTime TrnartFechaes { get; set; }

    public string TrnartTipo { get; set; } = null!;

    public DateTime? TrnartFechacaduca { get; set; }

    public string? TrnartReferencia { get; set; }

    public decimal TrnartCantidad { get; set; }

    public decimal TrnartCostot { get; set; }

    public string? TrnartHora { get; set; }

    public string? TrnartOrigen { get; set; }

    public string? TrnartArtext { get; set; }

    public decimal? TrnartCostoprom { get; set; }

    public decimal? FecJuliana { get; set; }

    public string? ArtpreCodbarra { get; set; }

    public virtual InvMaearticulo A { get; set; } = null!;
}
