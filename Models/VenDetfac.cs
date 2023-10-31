using System;
using System.Collections.Generic;

namespace BackProyTesis.Models;

public partial class VenDetfac
{
    public string Anio { get; set; } = null!;

    public string EncfacNumero { get; set; } = null!;

    public string ComCodigo { get; set; } = null!;

    public decimal DetfacLinea { get; set; }

    public string? DetfacTipodet { get; set; }

    public string? BodCodigo { get; set; }

    public string? DetfacCodigo { get; set; }

    public string? DetfacDescripcion { get; set; }

    //public string? DetfacUnidad { get; set; }

    public decimal? DetfacCantidad { get; set; }

    //public decimal? DetfacDespacho { get; set; }

    public decimal? DetfacPrecio { get; set; }

    public decimal? DetfacDescuento { get; set; }

    public decimal? DetfacTotal { get; set; }

    public string? DetfacTribiva { get; set; }

    public decimal? DetfacIva { get; set; }

    //public string? DetfacTribice { get; set; }

    //public decimal? DetfacIce { get; set; }

    //public decimal? DetfacPorceice { get; set; }

    //public string? DetfacLista { get; set; }

    //public decimal? DetfacBaseiva { get; set; }

    //public decimal? DetfacBaseice { get; set; }

    //public decimal? DetfacBasecero { get; set; }

    //public string? DetfacTipo { get; set; }

    //public string? DetfacCodigoref { get; set; }

    //public string? EnccotNumero { get; set; }

    //public decimal? DetcotLinea { get; set; }

    //public string? EncpedNumero { get; set; }

    //public decimal? DetpedLinea { get; set; }

    //public string? EncgreNumero { get; set; }

    //public decimal? DetgreLinea { get; set; }

    //public string? UniSimbolo { get; set; }

    //public string? DetfacPromocion { get; set; }

    public int? DetfacOrden { get; set; }

    //public string? DetfacSerial { get; set; }

    //public bool? DetfacFlag { get; set; }

    //public decimal? DetfacLinorgprom { get; set; }

    //public decimal? MaeprmCodigo { get; set; }

    public string? DetfacEmpleado { get; set; }

    //public decimal? DetfacValpgemp { get; set; }

    //public string? DetfacPvpcosto { get; set; }

    //public string? DetfacTrczsrvc { get; set; }

    //public decimal? DetfacPorcta { get; set; }

    //public decimal? DetfacPrcef { get; set; }

    //public decimal? DetfacPrcta { get; set; }

    //public decimal? DetfacPorcdscto2 { get; set; }

    public virtual VenEncfac VenEncfac { get; set; } = null!;

}
