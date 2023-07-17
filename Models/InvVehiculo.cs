using System;
using System.Collections.Generic;

namespace BackProyTesis.Models;

public partial class InvVehiculo
{
    public string InvCodigo { get; set; } = null!;

    public string InvDescrip { get; set; } = null!;

    public virtual ICollection<DetOrdInventario> DetOrdInventarios { get; set; } = new List<DetOrdInventario>();
}
