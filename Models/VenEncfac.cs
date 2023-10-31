using System;
using System.Collections.Generic;

namespace BackProyTesis.Models;

public partial class VenEncfac
{
    public string Anio { get; set; } = null!;

    public string EncfacNumero { get; set; } = null!;

    public string ComCodigo { get; set; } = null!;

    public DateTime? EncfacFechaemision { get; set; }

    public DateTime? EncfacFechaentrega { get; set; }

    //public string? EncfacIva { get; set; }

    public string? EncfacEstado { get; set; }

    public string? CliCodigo { get; set; }

    public string? CliNombre { get; set; }

    //public string? BodCodigo { get; set; }

    //public string? VenCodigo { get; set; }

    public string? EncfacReferencia { get; set; }

    //public string? EncffaCodigo { get; set; }

    public string? EncfacFormapago { get; set; }

    //public string? EncfacTipo { get; set; }

    //public string? EncfacLista { get; set; }

    public DateTime? EncfacFechavencimiento { get; set; }

    public decimal? EncfacTotal { get; set; }

    public decimal? EncfacTotalneto { get; set; }

    //public decimal? EncfacValordes { get; set; }

    //public decimal? EncfacPorcedes { get; set; }

    public decimal? EncfacValoriva { get; set; }

    public decimal? EncfacPorceiva { get; set; }

    //public decimal? EncfacValorice { get; set; }

    //public decimal? EncfacPorceice { get; set; }

    public decimal? EncfacBaseiva { get; set; }

    //public decimal? EncfacBaseice { get; set; }

    public decimal? EncfacBasecero { get; set; }

    //public decimal? EncfacPorcecar { get; set; }

    //public decimal? EncfacValorcar { get; set; }

    //public decimal? EncfacPorcertc { get; set; }

    //public decimal? EncfacValorrtc { get; set; }

    //public decimal? EncfacValordev { get; set; }

    //public decimal? EncfacBaseimp { get; set; }

    //public decimal? EncfacPorceint { get; set; }

    //public decimal? EncfacValorint { get; set; }

    //public decimal? EncfacPorcerec { get; set; }

    //public decimal? EncfacValorrec { get; set; }

    public string? EncfacImpreso { get; set; }

    public string? EncfacComentario { get; set; }

    //public string? EncfacTipofac { get; set; }

    //public string? EncfacGenerafac { get; set; }

    //public string? EncfacNumerodob { get; set; }

    //public string? EncfacDireccion { get; set; }

    //public string? EncfacTelefono { get; set; }

    //public string? EncfacRucide { get; set; }

    //public string? EncfacChofer { get; set; }

    //public string? EncfacCarro { get; set; }

    //public string? EncfacPlaca { get; set; }

    //public string? EncfacGrupo { get; set; }

    //public decimal? EncfacOtros { get; set; }

    //public string? EncfacNemonico { get; set; }

    //public string? EncfacSerie { get; set; }

    //public string? EncfacSecactual { get; set; }

    //public string? AsiNro { get; set; }

    //public int? EncfacDiascrdt { get; set; }

    //public decimal? EncfacClidsct { get; set; }

    public string? UsuIdentificacion { get; set; }

    //public string? EncfacObservacion { get; set; }

    //public bool? EncfacFlag { get; set; }

    //public string? EncfacTipodscto { get; set; }

    //public string? FormapagoTipo { get; set; }

    //public decimal? EncfacTotalretenido { get; set; }

    //public string? EncfacIdcretri { get; set; }

    //public string? EncfacTipcom { get; set; }

    //public decimal? EncfacPorcomtarj { get; set; }

    //public string? EncfacBanco { get; set; }

    //public string? EncfacPagotc { get; set; }

    //public string? EncfacMesestc { get; set; }

    //public decimal? EncfacMontivapreser { get; set; }

    //public string? EncfacPorivapreser { get; set; }

    //public decimal? EncfacMontretpreser { get; set; }

    //public decimal? EncfacMontivatrabie { get; set; }

    //public string? EncfacPorivatrabie { get; set; }

    //public decimal? EncfacMontrettrabie { get; set; }

    //public string? EncfacPvpcosto { get; set; }

    //public DateTime? TrnretencionFecemision { get; set; }

    //public string? GruCodigo { get; set; }

    //public string? EncfacFrmtfcnv { get; set; }

    //public string? EncfacRevisadofisico { get; set; }

    //public decimal? EncfacPagocontadota { get; set; }

    //public string? EncfacClinombre { get; set; }

    //public string? EncfacTipoide { get; set; }

    //public string? AsiNroret { get; set; }

    //public string? EncfacTipoempresa { get; set; }

    //public string? EncfacTaller { get; set; }

    //public int? EmpAsesor { get; set; }

    //public int? EmpAsesor2 { get; set; }

    //public string? EncfacDescformapago { get; set; }

    //public string? EncfacComprobante { get; set; }

    // public string? EncfacConfirma { get; set; }

    //public string? MaeserifactSerie { get; set; }

    //public string? MaeserifactCodigo { get; set; }

    //public string? EncfacEstadoFe { get; set; }

    //public DateTime? EncfacFechaautFe { get; set; }

    //public string? EncfacClaveaccesoFe { get; set; }

    //public string? EncfacAutorizacionFe { get; set; }

    //public string? EncfacSaciclavacce { get; set; }

    public string? Mes { get; set; }

    public string? Dia { get; set; }
    public string? EncfacGarantia { get; set; }

    public string? EncfacObsgarantia { get; set; }

    public virtual SegMaecompanium ComCodigoNavigation { get; set; } = null!;

    public virtual SegMaeusuario? UsuIdentificacionNavigation { get; set; }

    public virtual ICollection<VenDetfac> VenDetfacs { get; set; } = new List<VenDetfac>();

    public virtual VenMaecliente? VenMaecliente { get; set; }

    public virtual ICollection<VenVhcspcf> VenVhcspcfs { get; set; } = new List<VenVhcspcf>();

}