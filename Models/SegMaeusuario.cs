using System;
using System.Collections.Generic;

namespace BackProyTesis.Models;

public partial class SegMaeusuario
{
    public string Usuidentificacion { get; set; } = null!;

    public string Usuclave { get; set; } = null!;

    public string Usuruci { get; set; } = null!;

    public string Usuapellido { get; set; } = null!;

    public string Usunombre { get; set; } = null!;

    public string Comcodigo { get; set; } = null!;

    public string? Usuperfil { get; set; }

    public DateTime? Usufechainicio { get; set; }

    public DateTime? Usufechafinal { get; set; }

    public string? BodCodigo { get; set; }

    public virtual ICollection<VenEncfac> VenEncfacs { get; set; } = new List<VenEncfac>();
}
