using System;
using System.Collections.Generic;

namespace BackProyTesis.Models;

public partial class VenDetfacemp
{
    public string Anio { get; set; } = null!;

    public string EncfacNumero { get; set; } = null!;

    public string ComCodigo { get; set; } = null!;

    public decimal DetfacLinea { get; set; }

    public decimal? EmpCodigo { get; set; }

    public decimal DetfacempCodigo { get; set; }

    public string? DetfacempTipodet { get; set; }

    public string? ProCodigo { get; set; }

    public decimal? DetfacempOrden { get; set; }

    public virtual NomEmpleado? NomEmpleado { get; set; }
}
