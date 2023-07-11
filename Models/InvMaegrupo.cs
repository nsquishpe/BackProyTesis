using System;
using System.Collections.Generic;

namespace BackProyTesis.Models;

public partial class InvMaegrupo
{
    public string Anio { get; set; } = null!;

    public string GrupCodigo { get; set; } = null!;

    public string? GrupNombre { get; set; }

    //public string? ConCodigo { get; set; }

    public string? GrupCodigop { get; set; }

    public virtual ICollection<InvMaearticulo> InvMaearticulos { get; set; } = new List<InvMaearticulo>();
}
