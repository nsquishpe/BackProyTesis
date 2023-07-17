using System;
using System.Collections.Generic;

namespace BackProyTesis.Models;

public partial class DetOrdServicio
{
    public decimal DetSerLinea { get; set; }

    public decimal OrdNumero { get; set; }

    public string OrdAnio { get; set; } = null!;

    public string SerCodigo { get; set; } = null!;

    public string DetDescrip { get; set; } = null!;

    public virtual CabOrdenTrabajo Ord { get; set; } = null!;

    public virtual Servicio SerCodigoNavigation { get; set; } = null!;
}
