using System;
using System.Collections.Generic;

namespace BackProyTesis.Models;

public partial class DetOrdInventario
{
    public decimal DetInvLinea { get; set; }

    public decimal OrdNumero { get; set; }

    public string OrdAnio { get; set; } = null!;

    public string InvCodigo { get; set; } = null!;

    public string? InvDescrip { get; set; }

    public virtual InvVehiculo InvCodigoNavigation { get; set; } = null!;

    public virtual CabOrdenTrabajo Ord { get; set; } = null!;
}
