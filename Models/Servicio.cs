using System;
using System.Collections.Generic;

namespace BackProyTesis.Models;

public partial class Servicio
{
    public string SerCodigo { get; set; } = null!;

    public string SerDescrip { get; set; } = null!;

    public virtual ICollection<DetOrdServicio> DetOrdServicios { get; set; } = new List<DetOrdServicio>();
}
