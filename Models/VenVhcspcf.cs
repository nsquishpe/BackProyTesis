using System;
using System.Collections.Generic;

namespace BackProyTesis.Models;

public partial class VenVhcspcf
{
    public string Anio { get; set; } = null!;

    public decimal VhcspcfCodigo { get; set; }

    public string? ComCodigo { get; set; }

    public string? VhcspcfColor { get; set; }

    public string? VhcspcfMarca { get; set; }

    public string? VhcspcfOrden { get; set; }

    public string? EncfacNumero { get; set; }

    public string? EncfacComcodigo { get; set; }

    public string? VhcspcfTipo { get; set; }

    public decimal? VhcspcfChequeo { get; set; }

    public string? VhcspcfPlaca { get; set; }

    public string? VhcspcfMarcaDescrip { get; set; }

    public virtual VenEncfac? VenEncfac { get; set; }
}
