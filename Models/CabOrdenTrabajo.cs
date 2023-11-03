using System;
using System.Collections.Generic;

namespace BackProyTesis.Models;

public partial class CabOrdenTrabajo
{
    public decimal OrdNumero { get; set; }

    public string OrdAnio { get; set; } = null!;

    public DateTime OrdFecha { get; set; }

    public string? OrdObsv { get; set; }

    public string? OrdObsv1 { get; set; }

    public string CliCodigo { get; set; } = null!;

    public string CliNombre { get; set; } = null!;

    public string OrdPlaca { get; set; } = null!;

    public string? OrdKm { get; set; }

    public string? VehmarmodCodigo { get; set; }

    public string? MaecolorCodigo { get; set; }

    public virtual ICollection<DetOrdInventario> DetOrdInventarios { get; set; } = new List<DetOrdInventario>();

    public virtual ICollection<DetOrdServicio> DetOrdServicios { get; set; } = new List<DetOrdServicio>();

    public virtual VenMaecliente? VenMaecliente { get; set; } = null!;
}
