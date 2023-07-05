using System;
using System.Collections.Generic;

namespace BackProyTesis.Models;

public partial class SegMaecompanium
{
    public string Comcodigo { get; set; } = null!;

    public string Comruci { get; set; } = null!;

    public string Comnombre { get; set; } = null!;

    public string? Comdireccion { get; set; }

    public string? Comtelefono1 { get; set; }

    public string? Comtelefono2 { get; set; }

    public string? Comfax { get; set; }

    public string? Commultibodega { get; set; }

    public string? Comrepresentante { get; set; }

    public string? Comcorreo { get; set; }

    public string? Comprovincia { get; set; }

    public string? ComTpidrepre { get; set; }

    public string? ComIdrepre { get; set; }

    public string? ComRuccontador { get; set; }

    public string? Comnumest { get; set; }

    public string? ComlocalizacionRpt { get; set; }

    public string? ComautsriRet { get; set; }

    public string? ComserieRet { get; set; }

    public string? Comautorizacionsri { get; set; }

    public DateTime? Comfechainiciosri { get; set; }

    public DateTime? Comfechacaducidadsri { get; set; }

    public string? Comautoimpresor { get; set; }

    public string? Comsecuencialini { get; set; }

    public virtual ICollection<VenEncfac> VenEncfacs { get; set; } = new List<VenEncfac>();
}
