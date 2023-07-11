using System;
using System.Collections.Generic;

namespace BackProyTesis.Models;

public partial class NomEmpleado
{
    public string Anio { get; set; } = null!;

    public decimal EmpCodigo { get; set; }

    public string EmpAlias { get; set; } = null!;

    public string EmpNombre { get; set; } = null!;

    public string EmpApellido { get; set; } = null!;

    public string? EmpCedula { get; set; }

    public string? EmpDireccion1 { get; set; }

    //public string? EmpDireccion2 { get; set; }

    public string? EmpTelefono1 { get; set; }

    public string? EmpTelefono2 { get; set; }

    //public string ComCodigo { get; set; } = null!;

    public bool? EmpActivo { get; set; }

    //public string? ConCodigo { get; set; }

    //public decimal? EmpSueldobasico { get; set; }

    //public bool? EmpServgrua { get; set; }

    //public bool? EmpServtctr { get; set; }

    //public byte? MaedepCodigo { get; set; }

    //public decimal? EmpSueldofijo { get; set; }

    //public string? EmpSldfijo { get; set; }

    //public decimal? EmpNorol { get; set; }

    //public string? EmpDespfactura { get; set; }

    //public string? VenCodigo { get; set; }

    //public string? EmpObservacion { get; set; }

    //public DateTime? EmpFechanacimiento { get; set; }

    //public string? EmpIdtarjeta { get; set; }

    //public DateTime? EmpFechentrada { get; set; }

    //public DateTime? EmpFechsalida { get; set; }

    //public decimal? EmpBasiespat { get; set; }

    //public string? EmpIess { get; set; }

    //public decimal? EmpBaseminaprod { get; set; }

    //public bool? EmpAsesor { get; set; }

    //public decimal? EmpFondoreserva { get; set; }

    //public bool? EmpCalciesstoting { get; set; }

    public string? EmpCargo { get; set; }

    public virtual ICollection<VenDetfacemp> VenDetfacemps { get; set; } = new List<VenDetfacemp>();
}
