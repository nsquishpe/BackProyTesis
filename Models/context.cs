using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace BackProyTesis.Models;

public partial class context : DbContext
{
    public context()
    {
    }

    public context(DbContextOptions<context> options)
        : base(options)
    {
    }

    public virtual DbSet<InvMaearticulo> InvMaearticulos { get; set; }

    public virtual DbSet<InvTrnkardex> InvTrnkardices { get; set; }

    public virtual DbSet<SegMaecompanium> SegMaecompania { get; set; }

    public virtual DbSet<SegMaeusuario> SegMaeusuarios { get; set; }

    public virtual DbSet<VenDetfac> VenDetfacs { get; set; }

    public virtual DbSet<VenEncfac> VenEncfacs { get; set; }

    public virtual DbSet<VenMaecliente> VenMaeclientes { get; set; }

    public virtual DbSet<VenVhcspcf> VenVhcspcfs { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasDefaultSchema("PROYTESIS");

        modelBuilder.Entity<InvMaearticulo>(entity =>
        {
            entity.HasKey(e => new { e.Anio, e.ArtCodigo }).HasName("PK_INV_MAEARTICUL");

            entity.ToTable("INV_MAEARTICULO");

            entity.HasIndex(e => new { e.ArtCodigo, e.ComCodigo, e.Anio }, "PK_INV_MAEARTICULO").IsUnique();

            entity.Property(e => e.Anio)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("ANIO");
            entity.Property(e => e.ArtCodigo)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("ART_CODIGO");
            entity.Property(e => e.ArtAltura)
                .HasColumnType("FLOAT")
                .HasColumnName("ART_ALTURA");
            entity.Property(e => e.ArtAncho)
                .HasColumnType("FLOAT")
                .HasColumnName("ART_ANCHO");
            entity.Property(e => e.ArtCaduca)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("ART_CADUCA");
            entity.Property(e => e.ArtCantmax)
                .HasColumnType("FLOAT")
                .HasColumnName("ART_CANTMAX");
            entity.Property(e => e.ArtCantmin)
                .HasColumnType("FLOAT")
                .HasColumnName("ART_CANTMIN");
            entity.Property(e => e.ArtCodigoalt1)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("ART_CODIGOALT1");
            entity.Property(e => e.ArtCodigoalt2)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("ART_CODIGOALT2");
            entity.Property(e => e.ArtCodigoalt3)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("ART_CODIGOALT3");
            entity.Property(e => e.ArtCodigoalt4)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("ART_CODIGOALT4");
            entity.Property(e => e.ArtCodigoice)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("ART_CODIGOICE");
            entity.Property(e => e.ArtCompuesto)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("ART_COMPUESTO");
            entity.Property(e => e.ArtDescuento)
                .HasColumnType("FLOAT")
                .HasColumnName("ART_DESCUENTO");
            entity.Property(e => e.ArtDiasgarantia)
                .HasColumnType("FLOAT")
                .HasColumnName("ART_DIASGARANTIA");
            entity.Property(e => e.ArtFactor)
                .HasColumnType("FLOAT")
                .HasColumnName("ART_FACTOR");
            entity.Property(e => e.ArtFechaing)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("ART_FECHAING");
            entity.Property(e => e.ArtFlag)
                .IsRequired()
                .HasPrecision(1)
                .HasDefaultValueSql("1                     ")
                .HasColumnName("ART_FLAG");
            entity.Property(e => e.ArtFormavta)
                .HasPrecision(1)
                .HasColumnName("ART_FORMAVTA");
            entity.Property(e => e.ArtInactivo)
                .HasPrecision(1)
                .HasColumnName("ART_INACTIVO");
            entity.Property(e => e.ArtLaboratorio)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("ART_LABORATORIO");
            entity.Property(e => e.ArtLargo)
                .HasColumnType("FLOAT")
                .HasColumnName("ART_LARGO");
            entity.Property(e => e.ArtMarca)
                .HasMaxLength(45)
                .IsUnicode(false)
                .HasColumnName("ART_MARCA");
            entity.Property(e => e.ArtModelo)
                .HasMaxLength(45)
                .IsUnicode(false)
                .HasColumnName("ART_MODELO");
            entity.Property(e => e.ArtMultiunidad)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("ART_MULTIUNIDAD");
            entity.Property(e => e.ArtNombre)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("ART_NOMBRE");
            entity.Property(e => e.ArtNombrec)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("ART_NOMBREC");
            entity.Property(e => e.ArtObservacion)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("ART_OBSERVACION");
            entity.Property(e => e.ArtPeso)
                .HasColumnType("FLOAT")
                .HasColumnName("ART_PESO");
            entity.Property(e => e.ArtSecbodtrans)
                .HasColumnType("NUMBER")
                .HasColumnName("ART_SECBODTRANS");
            entity.Property(e => e.ArtSerialflag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("'N'")
                .HasColumnName("ART_SERIALFLAG");
            entity.Property(e => e.ArtSerie)
                .HasMaxLength(45)
                .IsUnicode(false)
                .HasColumnName("ART_SERIE");
            entity.Property(e => e.ArtTributaice)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("ART_TRIBUTAICE");
            entity.Property(e => e.ArtTributaiva)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("ART_TRIBUTAIVA");
            entity.Property(e => e.ArtUbicacion)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ART_UBICACION");
            entity.Property(e => e.ArtUnidadcosteo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("ART_UNIDADCOSTEO");
            entity.Property(e => e.ArtUnidadventa)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("ART_UNIDADVENTA");
            entity.Property(e => e.ArtValorice)
                .HasColumnType("FLOAT")
                .HasColumnName("ART_VALORICE");
            entity.Property(e => e.ArtVolumen)
                .HasColumnType("FLOAT")
                .HasColumnName("ART_VOLUMEN");
            entity.Property(e => e.BodCodigo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("BOD_CODIGO");
            entity.Property(e => e.ComCodigo)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("COM_CODIGO");
            entity.Property(e => e.ConCodigoact)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("CON_CODIGOACT");
            entity.Property(e => e.ConCodigogas)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("CON_CODIGOGAS");
            entity.Property(e => e.ConCodigoing)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("CON_CODIGOING");
            entity.Property(e => e.ConCodigoord1)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("CON_CODIGOORD1");
            entity.Property(e => e.ConCodigoord2)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("CON_CODIGOORD2");
            entity.Property(e => e.GrupCodigo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("GRUP_CODIGO");
            entity.Property(e => e.GrupCodigop)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("GRUP_CODIGOP");
            entity.Property(e => e.PresentacionCodigo)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("PRESENTACION_CODIGO");
            entity.Property(e => e.VenCodigo)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("VEN_CODIGO");
        });

        modelBuilder.Entity<InvTrnkardex>(entity =>
        {
            entity.HasKey(e => new { e.ArtCodigo, e.ComCodigo, e.BodCodigo, e.TrnartNumero, e.Anio }).HasName("INV_TRNKARDEX_PK11038930882281");

            entity.ToTable("INV_TRNKARDEX");

            entity.Property(e => e.ArtCodigo)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("ART_CODIGO");
            entity.Property(e => e.ComCodigo)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("COM_CODIGO");
            entity.Property(e => e.BodCodigo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("BOD_CODIGO");
            entity.Property(e => e.TrnartNumero)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("TRNART_NUMERO");
            entity.Property(e => e.Anio)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("ANIO");
            entity.Property(e => e.ArtpreCodbarra)
                .HasMaxLength(35)
                .IsUnicode(false)
                .HasColumnName("ARTPRE_CODBARRA");
            entity.Property(e => e.Dia)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("DIA");
            entity.Property(e => e.FecJuliana)
                .HasColumnType("NUMBER")
                .HasColumnName("FEC_JULIANA");
            entity.Property(e => e.Mes)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("MES");
            entity.Property(e => e.TrnartArtext)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("TRNART_ARTEXT");
            entity.Property(e => e.TrnartCantidad)
                .HasColumnType("FLOAT")
                .HasColumnName("TRNART_CANTIDAD");
            entity.Property(e => e.TrnartCostoprom)
                .HasColumnType("FLOAT")
                .HasColumnName("TRNART_COSTOPROM");
            entity.Property(e => e.TrnartCostot)
                .HasColumnType("FLOAT")
                .HasColumnName("TRNART_COSTOT");
            entity.Property(e => e.TrnartFechacaduca)
                .HasColumnType("DATE")
                .HasColumnName("TRNART_FECHACADUCA");
            entity.Property(e => e.TrnartFechaes)
                .HasColumnType("DATE")
                .HasColumnName("TRNART_FECHAES");
            entity.Property(e => e.TrnartHora)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("TRNART_HORA");
            entity.Property(e => e.TrnartOrigen)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("TRNART_ORIGEN");
            entity.Property(e => e.TrnartReferencia)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("TRNART_REFERENCIA");
            entity.Property(e => e.TrnartTipo)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("TRNART_TIPO");

            entity.HasOne(d => d.A).WithMany(p => p.InvTrnkardices)
                .HasForeignKey(d => new { d.Anio, d.ArtCodigo })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CODIGO_ARTICULO");
        });

        modelBuilder.Entity<SegMaecompanium>(entity =>
        {
            entity.HasKey(e => e.Comcodigo).HasName("SEG_MAECOMPAN_PK01034886113734");

            entity.ToTable("SEG_MAECOMPANIA");

            entity.Property(e => e.Comcodigo)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("COMCODIGO");
            entity.Property(e => e.ComIdrepre)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("COM_IDREPRE");
            entity.Property(e => e.ComRuccontador)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasColumnName("COM_RUCCONTADOR");
            entity.Property(e => e.ComTpidrepre)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("COM_TPIDREPRE");
            entity.Property(e => e.Comautoimpresor)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("COMAUTOIMPRESOR");
            entity.Property(e => e.Comautorizacionsri)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("COMAUTORIZACIONSRI");
            entity.Property(e => e.ComautsriRet)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("COMAUTSRI_RET");
            entity.Property(e => e.Comcorreo)
                .HasMaxLength(25)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("COMCORREO");
            entity.Property(e => e.Comdireccion)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("COMDIRECCION");
            entity.Property(e => e.Comfax)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("COMFAX");
            entity.Property(e => e.Comfechacaducidadsri)
                .HasColumnType("DATE")
                .HasColumnName("COMFECHACADUCIDADSRI");
            entity.Property(e => e.Comfechainiciosri)
                .HasColumnType("DATE")
                .HasColumnName("COMFECHAINICIOSRI");
            entity.Property(e => e.ComlocalizacionRpt)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("COMLOCALIZACION_RPT");
            entity.Property(e => e.Commultibodega)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("COMMULTIBODEGA");
            entity.Property(e => e.Comnombre)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("COMNOMBRE");
            entity.Property(e => e.Comnumest)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("COMNUMEST");
            entity.Property(e => e.Comprovincia)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("COMPROVINCIA");
            entity.Property(e => e.Comrepresentante)
                .HasMaxLength(45)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("COMREPRESENTANTE");
            entity.Property(e => e.Comruci)
                .HasMaxLength(14)
                .IsUnicode(false)
                .HasColumnName("COMRUCI");
            entity.Property(e => e.Comsecuencialini)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasColumnName("COMSECUENCIALINI");
            entity.Property(e => e.ComserieRet)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("COMSERIE_RET");
            entity.Property(e => e.Comtelefono1)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("COMTELEFONO1");
            entity.Property(e => e.Comtelefono2)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("COMTELEFONO2");
        });

        modelBuilder.Entity<SegMaeusuario>(entity =>
        {
            entity.HasKey(e => e.Usuidentificacion).HasName("SEG_MAEUSUARIO_PK");

            entity.ToTable("SEG_MAEUSUARIO");

            entity.Property(e => e.Usuidentificacion)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("USUIDENTIFICACION");
            entity.Property(e => e.BodCodigo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("BOD_CODIGO");
            entity.Property(e => e.Comcodigo)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("COMCODIGO");
            entity.Property(e => e.Usuapellido)
                .HasMaxLength(45)
                .IsUnicode(false)
                .HasColumnName("USUAPELLIDO");
            entity.Property(e => e.Usuclave)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("USUCLAVE");
            entity.Property(e => e.Usufechafinal)
                .HasColumnType("DATE")
                .HasColumnName("USUFECHAFINAL");
            entity.Property(e => e.Usufechainicio)
                .HasColumnType("DATE")
                .HasColumnName("USUFECHAINICIO");
            entity.Property(e => e.Usunombre)
                .HasMaxLength(45)
                .IsUnicode(false)
                .HasColumnName("USUNOMBRE");
            entity.Property(e => e.Usuperfil)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("USUPERFIL");
            entity.Property(e => e.Usuruci)
                .HasMaxLength(14)
                .IsUnicode(false)
                .HasColumnName("USURUCI");
        });

        modelBuilder.Entity<VenDetfac>(entity =>
        {
            entity.HasKey(e => new { e.Anio, e.EncfacNumero, e.ComCodigo, e.DetfacLinea });

            entity.ToTable("VEN_DETFAC");

            entity.Property(e => e.Anio)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("ANIO");
            entity.Property(e => e.EncfacNumero)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ENCFAC_NUMERO");
            entity.Property(e => e.ComCodigo)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("COM_CODIGO");
            entity.Property(e => e.DetfacLinea)
                .HasColumnType("NUMBER(38)")
                .HasColumnName("DETFAC_LINEA");
            entity.Property(e => e.BodCodigo)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("BOD_CODIGO");
            /*entity.Property(e => e.DetcotLinea)
                .HasColumnType("NUMBER")
                .HasColumnName("DETCOT_LINEA");
            entity.Property(e => e.DetfacBasecero)
                .HasColumnType("FLOAT")
                .HasColumnName("DETFAC_BASECERO");
            entity.Property(e => e.DetfacBaseice)
                .HasColumnType("FLOAT")
                .HasColumnName("DETFAC_BASEICE");
            entity.Property(e => e.DetfacBaseiva)
                .HasColumnType("FLOAT")
                .HasColumnName("DETFAC_BASEIVA"); */
            entity.Property(e => e.DetfacCantidad)
                .HasColumnType("FLOAT")
                .HasColumnName("DETFAC_CANTIDAD");
            entity.Property(e => e.DetfacCodigo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("DETFAC_CODIGO");
            /*entity.Property(e => e.DetfacCodigoref)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("DETFAC_CODIGOREF");*/
            entity.Property(e => e.DetfacDescripcion)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("DETFAC_DESCRIPCION");
            entity.Property(e => e.DetfacDescuento)
                .HasColumnType("FLOAT")
                .HasColumnName("DETFAC_DESCUENTO");
            /*entity.Property(e => e.DetfacDespacho)
                .HasColumnType("FLOAT")
                .HasColumnName("DETFAC_DESPACHO");
            entity.Property(e => e.DetfacEmpleado)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DETFAC_EMPLEADO");
            entity.Property(e => e.DetfacFlag)
                .IsRequired()
                .HasPrecision(1)
                .HasDefaultValueSql("0                     ")
                .HasColumnName("DETFAC_FLAG");
            entity.Property(e => e.DetfacIce)
                .HasColumnType("FLOAT")
                .HasColumnName("DETFAC_ICE");*/
            entity.Property(e => e.DetfacIva)
                .HasColumnType("FLOAT")
                .HasColumnName("DETFAC_IVA");
            /*entity.Property(e => e.DetfacLinorgprom)
                .HasColumnType("NUMBER(38)")
                .HasColumnName("DETFAC_LINORGPROM");
            entity.Property(e => e.DetfacLista)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("DETFAC_LISTA"); */
            entity.Property(e => e.DetfacOrden)
                .HasPrecision(10)
                .HasColumnName("DETFAC_ORDEN");
            /*entity.Property(e => e.DetfacPorcdscto2)
                .HasColumnType("FLOAT")
                .HasColumnName("DETFAC_PORCDSCTO2");
            entity.Property(e => e.DetfacPorceice)
                .HasColumnType("FLOAT")
                .HasColumnName("DETFAC_PORCEICE");
            entity.Property(e => e.DetfacPorcta)
                .HasColumnType("FLOAT")
                .HasColumnName("DETFAC_PORCTA");
            entity.Property(e => e.DetfacPrcef)
                .HasColumnType("FLOAT")
                .HasColumnName("DETFAC_PRCEF");
            entity.Property(e => e.DetfacPrcta)
                .HasColumnType("FLOAT")
                .HasColumnName("DETFAC_PRCTA"); */
            entity.Property(e => e.DetfacPrecio)
                .HasColumnType("FLOAT")
                .HasColumnName("DETFAC_PRECIO");
            /*entity.Property(e => e.DetfacPromocion)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("0")
                .HasColumnName("DETFAC_PROMOCION");
            entity.Property(e => e.DetfacPvpcosto)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("'0'")
                .HasColumnName("DETFAC_PVPCOSTO");
            entity.Property(e => e.DetfacSerial)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("DETFAC_SERIAL");
            entity.Property(e => e.DetfacTipo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("DETFAC_TIPO"); */
            entity.Property(e => e.DetfacTipodet)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("DETFAC_TIPODET");
            entity.Property(e => e.DetfacTotal)
                .HasColumnType("FLOAT")
                .HasColumnName("DETFAC_TOTAL");
            /* entity.Property(e => e.DetfacTrczsrvc)
                 .HasMaxLength(1)
                 .IsUnicode(false)
                 .HasColumnName("DETFAC_TRCZSRVC");
            entity.Property(e => e.DetfacTribice)
                 .HasMaxLength(1)
                 .IsUnicode(false)
                 .HasColumnName("DETFAC_TRIBICE"); */
             entity.Property(e => e.DetfacTribiva)
                 .HasMaxLength(1)
                 .IsUnicode(false)
                 .HasColumnName("DETFAC_TRIBIVA");
            /* entity.Property(e => e.DetfacUnidad)
                 .HasMaxLength(10)
                 .IsUnicode(false)
                 .HasColumnName("DETFAC_UNIDAD");
            entity.Property(e => e.DetfacValpgemp)
                 .HasColumnType("FLOAT")
                 .HasColumnName("DETFAC_VALPGEMP");
            entity.Property(e => e.DetgreLinea)
                 .HasColumnType("NUMBER")
                 .HasColumnName("DETGRE_LINEA");
            /* entity.Property(e => e.DetpedLinea)
                 .HasColumnType("NUMBER")
                 .HasColumnName("DETPED_LINEA");
            entity.Property(e => e.EnccotNumero)
                 .HasMaxLength(50)
                 .IsUnicode(false)
                 .HasColumnName("ENCCOT_NUMERO");
             entity.Property(e => e.EncgreNumero)
                 .HasMaxLength(50)
                 .IsUnicode(false)
                 .HasColumnName("ENCGRE_NUMERO");
             entity.Property(e => e.EncpedNumero)
                 .HasMaxLength(50)
                 .IsUnicode(false)
                 .HasColumnName("ENCPED_NUMERO");
             entity.Property(e => e.MaeprmCodigo)
                 .HasColumnType("NUMBER")
                 .HasColumnName("MAEPRM_CODIGO");
             entity.Property(e => e.UniSimbolo)
                 .HasMaxLength(10)
                 .IsUnicode(false)
                 .HasColumnName("UNI_SIMBOLO"); */

             entity.HasOne(d => d.VenEncfac).WithMany(p => p.VenDetfacs)
                 .HasForeignKey(d => new { d.EncfacNumero, d.ComCodigo, d.Anio })
                 .OnDelete(DeleteBehavior.ClientSetNull)
                 .HasConstraintName("VEN_DETFAC_FK21069863163491");
         });

         modelBuilder.Entity<VenEncfac>(entity =>
         {
             entity.HasKey(e => new { e.EncfacNumero, e.ComCodigo, e.Anio });

             entity.ToTable("VEN_ENCFAC");

             entity.Property(e => e.EncfacNumero)
                 .HasMaxLength(50)
                 .IsUnicode(false)
                 .HasColumnName("ENCFAC_NUMERO");
             entity.Property(e => e.ComCodigo)
                 .HasMaxLength(2)
                 .IsUnicode(false)
                 .HasColumnName("COM_CODIGO");
             entity.Property(e => e.Anio)
                 .HasMaxLength(4)
                 .IsUnicode(false)
                 .HasColumnName("ANIO");
             /*entity.Property(e => e.AsiNro)
                 .HasMaxLength(20)
                 .IsUnicode(false)
                 .HasColumnName("ASI_NRO");
             entity.Property(e => e.AsiNroret)
                 .HasMaxLength(20)
                 .IsUnicode(false)
                 .HasColumnName("ASI_NRORET");
             entity.Property(e => e.BodCodigo)
                 .HasMaxLength(5)
                 .IsUnicode(false)
                 .HasColumnName("BOD_CODIGO"); */
            entity.Property(e => e.CliCodigo)
                .HasMaxLength(14)
                .IsUnicode(false)
                .HasColumnName("CLI_CODIGO");
            entity.Property(e => e.CliNombre)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("CLI_NOMBRE");
            entity.Property(e => e.Dia)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("DIA");
            /*entity.Property(e => e.EmpAsesor)
                .HasPrecision(10)
                .HasColumnName("EMP_ASESOR");
            entity.Property(e => e.EmpAsesor2)
                .HasPrecision(10)
                .HasColumnName("EMP_ASESOR_2"); 
            entity.Property(e => e.EncfacAutorizacionFe)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("ENCFAC_AUTORIZACION_FE");
            entity.Property(e => e.EncfacBanco)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ENCFAC_BANCO"); */
            entity.Property(e => e.EncfacBasecero)
                .HasColumnType("FLOAT")
                .HasColumnName("ENCFAC_BASECERO");
            /*entity.Property(e => e.EncfacBaseice)
                .HasColumnType("FLOAT")
                .HasColumnName("ENCFAC_BASEICE");
            entity.Property(e => e.EncfacBaseimp)
                .HasColumnType("FLOAT")
                .HasColumnName("ENCFAC_BASEIMP"); */
            entity.Property(e => e.EncfacBaseiva)
                .HasColumnType("FLOAT")
                .HasColumnName("ENCFAC_BASEIVA");
            /*entity.Property(e => e.EncfacCarro)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ENCFAC_CARRO");
            entity.Property(e => e.EncfacChofer)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ENCFAC_CHOFER");
            entity.Property(e => e.EncfacClaveaccesoFe)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("ENCFAC_CLAVEACCESO_FE");
            entity.Property(e => e.EncfacClidsct)
                .HasColumnType("FLOAT")
                .HasColumnName("ENCFAC_CLIDSCT");
            entity.Property(e => e.EncfacClinombre)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("ENCFAC_CLINOMBRE"); */
            entity.Property(e => e.EncfacComentario)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("ENCFAC_COMENTARIO");
            /*entity.Property(e => e.EncfacComprobante)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ENCFAC_COMPROBANTE");
            entity.Property(e => e.EncfacConfirma)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("ENCFAC_CONFIRMA");
            entity.Property(e => e.EncfacDescformapago)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("ENCFAC_DESCFORMAPAGO");
            entity.Property(e => e.EncfacDiascrdt)
                .HasPrecision(10)
                .HasColumnName("ENCFAC_DIASCRDT");
            entity.Property(e => e.EncfacDireccion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ENCFAC_DIRECCION"); */
            entity.Property(e => e.EncfacEstado)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("ENCFAC_ESTADO");
            /*entity.Property(e => e.EncfacEstadoFe)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("ENCFAC_ESTADO_FE");
            entity.Property(e => e.EncfacFechaautFe)
                .HasColumnType("DATE")
                .HasColumnName("ENCFAC_FECHAAUT_FE"); */
            entity.Property(e => e.EncfacFechaemision)
                .HasColumnType("DATE")
                .HasColumnName("ENCFAC_FECHAEMISION");
            entity.Property(e => e.EncfacFechaentrega)
                .HasColumnType("DATE")
                .HasColumnName("ENCFAC_FECHAENTREGA");
            entity.Property(e => e.EncfacFechavencimiento)
                .HasColumnType("DATE")
                .HasColumnName("ENCFAC_FECHAVENCIMIENTO");
            /*entity.Property(e => e.EncfacFlag)
                .IsRequired()
                .HasPrecision(1)
                .HasDefaultValueSql("0                     ")
                .HasColumnName("ENCFAC_FLAG");*/
            entity.Property(e => e.EncfacFormapago)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("ENCFAC_FORMAPAGO");
            /*entity.Property(e => e.EncfacFrmtfcnv)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("ENCFAC_FRMTFCNV");
            entity.Property(e => e.EncfacGenerafac)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("ENCFAC_GENERAFAC");
            entity.Property(e => e.EncfacGrupo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ENCFAC_GRUPO");
            entity.Property(e => e.EncfacIdcretri)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("ENCFAC_IDCRETRI"); */
            entity.Property(e => e.EncfacImpreso)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("ENCFAC_IMPRESO");
            /*entity.Property(e => e.EncfacIva)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("ENCFAC_IVA");
            entity.Property(e => e.EncfacLista)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("ENCFAC_LISTA");
            entity.Property(e => e.EncfacMesestc)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("ENCFAC_MESESTC");
            entity.Property(e => e.EncfacMontivapreser)
                .HasColumnType("FLOAT")
                .HasColumnName("ENCFAC_MONTIVAPRESER");
            entity.Property(e => e.EncfacMontivatrabie)
                .HasColumnType("FLOAT")
                .HasColumnName("ENCFAC_MONTIVATRABIE");
            entity.Property(e => e.EncfacMontretpreser)
                .HasColumnType("FLOAT")
                .HasColumnName("ENCFAC_MONTRETPRESER");
            entity.Property(e => e.EncfacMontrettrabie)
                .HasColumnType("FLOAT")
                .HasColumnName("ENCFAC_MONTRETTRABIE");
            entity.Property(e => e.EncfacNemonico)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("ENCFAC_NEMONICO");
            entity.Property(e => e.EncfacNumerodob)
                .HasMaxLength(17)
                .IsUnicode(false)
                .HasColumnName("ENCFAC_NUMERODOB");
            entity.Property(e => e.EncfacObservacion)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("ENCFAC_OBSERVACION");
            entity.Property(e => e.EncfacOtros)
                .HasColumnType("FLOAT")
                .HasColumnName("ENCFAC_OTROS");
            entity.Property(e => e.EncfacPagocontadota)
                .HasColumnType("FLOAT")
                .HasColumnName("ENCFAC_PAGOCONTADOTA");
            entity.Property(e => e.EncfacPagotc)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("ENCFAC_PAGOTC");
            entity.Property(e => e.EncfacPlaca)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("ENCFAC_PLACA");
            entity.Property(e => e.EncfacPorcecar)
                .HasColumnType("FLOAT")
                .HasColumnName("ENCFAC_PORCECAR");
            entity.Property(e => e.EncfacPorcedes)
                .HasColumnType("FLOAT")
                .HasColumnName("ENCFAC_PORCEDES");
            entity.Property(e => e.EncfacPorceice)
                .HasColumnType("FLOAT")
                .HasColumnName("ENCFAC_PORCEICE");
            entity.Property(e => e.EncfacPorceint)
                .HasColumnType("FLOAT")
                .HasColumnName("ENCFAC_PORCEINT"); */
            entity.Property(e => e.EncfacPorceiva)
                .HasColumnType("FLOAT")
                .HasColumnName("ENCFAC_PORCEIVA");
            /*entity.Property(e => e.EncfacPorcerec)
                .HasColumnType("FLOAT")
                .HasColumnName("ENCFAC_PORCEREC");
            entity.Property(e => e.EncfacPorcertc)
                .HasColumnType("FLOAT")
                .HasColumnName("ENCFAC_PORCERTC");
            entity.Property(e => e.EncfacPorcomtarj)
                .HasColumnType("FLOAT")
                .HasColumnName("ENCFAC_PORCOMTARJ");
            entity.Property(e => e.EncfacPorivapreser)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("ENCFAC_PORIVAPRESER");
            entity.Property(e => e.EncfacPorivatrabie)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("ENCFAC_PORIVATRABIE");
            entity.Property(e => e.EncfacPvpcosto)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("'0'")
                .HasColumnName("ENCFAC_PVPCOSTO"); */
            entity.Property(e => e.EncfacReferencia)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("ENCFAC_REFERENCIA");
            /*entity.Property(e => e.EncfacRevisadofisico)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("ENCFAC_REVISADOFISICO");
            entity.Property(e => e.EncfacRucide)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("ENCFAC_RUCIDE");
            entity.Property(e => e.EncfacSaciclavacce)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("ENCFAC_SACICLAVACCE");
            entity.Property(e => e.EncfacSecactual)
                .HasMaxLength(14)
                .IsUnicode(false)
                .HasColumnName("ENCFAC_SECACTUAL");
            entity.Property(e => e.EncfacSerie)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("ENCFAC_SERIE");
            entity.Property(e => e.EncfacTaller)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("ENCFAC_TALLER");
            entity.Property(e => e.EncfacTelefono)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ENCFAC_TELEFONO");
            entity.Property(e => e.EncfacTipcom)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("ENCFAC_TIPCOM");
            entity.Property(e => e.EncfacTipo)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("ENCFAC_TIPO");
            entity.Property(e => e.EncfacTipodscto)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("ENCFAC_TIPODSCTO");
            entity.Property(e => e.EncfacTipoempresa)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("ENCFAC_TIPOEMPRESA");
            entity.Property(e => e.EncfacTipofac)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("ENCFAC_TIPOFAC");
            entity.Property(e => e.EncfacTipoide)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("ENCFAC_TIPOIDE"); */
            entity.Property(e => e.EncfacTotal)
                .HasColumnType("FLOAT")
                .HasColumnName("ENCFAC_TOTAL");
            entity.Property(e => e.EncfacTotalneto)
                .HasColumnType("FLOAT")
                .HasColumnName("ENCFAC_TOTALNETO");
            /*entity.Property(e => e.EncfacTotalretenido)
                .HasColumnType("FLOAT")
                .HasColumnName("ENCFAC_TOTALRETENIDO");
            entity.Property(e => e.EncfacValorcar)
                .HasColumnType("FLOAT")
                .HasColumnName("ENCFAC_VALORCAR");
            entity.Property(e => e.EncfacValordes)
                .HasColumnType("FLOAT")
                .HasColumnName("ENCFAC_VALORDES");
            entity.Property(e => e.EncfacValordev)
                .HasColumnType("FLOAT")
                .HasColumnName("ENCFAC_VALORDEV");
            entity.Property(e => e.EncfacValorice)
                .HasColumnType("FLOAT")
                .HasColumnName("ENCFAC_VALORICE");
            entity.Property(e => e.EncfacValorint)
                .HasColumnType("FLOAT")
                .HasColumnName("ENCFAC_VALORINT"); */
            entity.Property(e => e.EncfacValoriva)
                .HasColumnType("FLOAT")
                .HasColumnName("ENCFAC_VALORIVA");
            /*entity.Property(e => e.EncfacValorrec)
                .HasColumnType("FLOAT")
                .HasColumnName("ENCFAC_VALORREC");
            entity.Property(e => e.EncfacValorrtc)
                .HasColumnType("FLOAT")
                .HasColumnName("ENCFAC_VALORRTC");
            entity.Property(e => e.EncffaCodigo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ENCFFA_CODIGO");
            entity.Property(e => e.FormapagoTipo)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("FORMAPAGO_TIPO");
            entity.Property(e => e.GruCodigo)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("GRU_CODIGO");
            entity.Property(e => e.MaeserifactCodigo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("MAESERIFACT_CODIGO");
            entity.Property(e => e.MaeserifactSerie)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("MAESERIFACT_SERIE"); */
            entity.Property(e => e.Mes)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("MES");
            /*entity.Property(e => e.TrnretencionFecemision)
                .HasColumnType("DATE")
                .HasColumnName("TRNRETENCION_FECEMISION");*/
            entity.Property(e => e.UsuIdentificacion)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("USU_IDENTIFICACION");
            /*entity.Property(e => e.VenCodigo)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("VEN_CODIGO");*/

            entity.HasOne(d => d.ComCodigoNavigation).WithMany(p => p.VenEncfacs)
                .HasForeignKey(d => d.ComCodigo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CODIGO_COMPANIA");

            entity.HasOne(d => d.UsuIdentificacionNavigation).WithMany(p => p.VenEncfacs)
                .HasForeignKey(d => d.UsuIdentificacion)
                .HasConstraintName("FK_CODIGO_USUARIO");

            entity.HasOne(d => d.VenMaecliente).WithMany(p => p.VenEncfacs)
                .HasForeignKey(d => new { d.Anio, d.CliCodigo })
                .HasConstraintName("FK_CODIGO_CLIENTE");
        });

        modelBuilder.Entity<VenMaecliente>(entity =>
        {
            entity.HasKey(e => new { e.Anio, e.CliCodigo }).HasName("VEN_MAECLIENT_PK11042218726875");

            entity.ToTable("VEN_MAECLIENTE");

            entity.Property(e => e.Anio)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("ANIO");
            entity.Property(e => e.CliCodigo)
                .HasMaxLength(14)
                .IsUnicode(false)
                .HasColumnName("CLI_CODIGO");
            /*entity.Property(e => e.CbrCodigo)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("CBR_CODIGO");
            entity.Property(e => e.CiuCodigo)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("CIU_CODIGO");
            entity.Property(e => e.CliCodiformpago1)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValueSql("'01'")
                .HasColumnName("CLI_CODIFORMPAGO_1");
            entity.Property(e => e.CliCodiformpago2)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("CLI_CODIFORMPAGO_2");
            entity.Property(e => e.CliCodpostal)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("CLI_CODPOSTAL");
            entity.Property(e => e.CliCodseguridad)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CLI_CODSEGURIDAD");
            entity.Property(e => e.CliContacto)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("CLI_CONTACTO");
            entity.Property(e => e.CliContribuyente)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("CLI_CONTRIBUYENTE"); */
            entity.Property(e => e.CliCorreo)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasDefaultValueSql("'diego.quishpe.mecanica.automotriz@gmail.com'")
                .HasColumnName("CLI_CORREO");
            /*entity.Property(e => e.CliDescuento)
                .HasColumnType("FLOAT")
                .HasColumnName("CLI_DESCUENTO");
            entity.Property(e => e.CliDiacredit)
                .HasColumnType("NUMBER(38)")
                .HasColumnName("CLI_DIACREDIT");*/
            entity.Property(e => e.CliDireccion1)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CLI_DIRECCION1");
            /*entity.Property(e => e.CliDireccion2)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CLI_DIRECCION2");
            entity.Property(e => e.CliEstado)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("CLI_ESTADO");
            entity.Property(e => e.CliFax)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("CLI_FAX");
            entity.Property(e => e.CliFechaultpag)
                .HasColumnType("DATE")
                .HasColumnName("CLI_FECHAULTPAG");
            entity.Property(e => e.CliFecing)
                .HasColumnType("DATE")
                .HasColumnName("CLI_FECING");
            entity.Property(e => e.CliFlag)
                .IsRequired()
                .HasPrecision(1)
                .HasDefaultValueSql("1                     ")
                .HasColumnName("CLI_FLAG");
            entity.Property(e => e.CliIva)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("CLI_IVA");
            entity.Property(e => e.CliLimcredit)
                .HasColumnType("FLOAT")
                .HasColumnName("CLI_LIMCREDIT");
            entity.Property(e => e.CliLinneg)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("CLI_LINNEG");
            entity.Property(e => e.CliLista)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("CLI_LISTA"); */
            entity.Property(e => e.CliNombre)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("CLI_NOMBRE");
            /*entity.Property(e => e.CliNombrec)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("CLI_NOMBREC");
            entity.Property(e => e.CliObservacion)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CLI_OBSERVACION");
            entity.Property(e => e.CliPorcedescuento)
                .HasColumnType("NUMBER(38)")
                .HasColumnName("CLI_PORCEDESCUENTO");
            entity.Property(e => e.CliPorcerecargo)
                .HasColumnType("NUMBER(38)")
                .HasColumnName("CLI_PORCERECARGO");
            entity.Property(e => e.CliProvincia)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("CLI_PROVINCIA");
            entity.Property(e => e.CliRucide)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("CLI_RUCIDE"); */
            entity.Property(e => e.CliSaldo)
                .HasColumnType("FLOAT")
                .HasColumnName("CLI_SALDO");
            entity.Property(e => e.CliTelefono1)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("CLI_TELEFONO1");
            /*entity.Property(e => e.CliTelefono2)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("CLI_TELEFONO2");
            entity.Property(e => e.CliTipo)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("CLI_TIPO"); */
            entity.Property(e => e.CliTipoide)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("CLI_TIPOIDE");
            /*entity.Property(e => e.CliTrfiva)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("CLI_TRFIVA");
            entity.Property(e => e.CliTrfretencion)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("CLI_TRFRETENCION");
            entity.Property(e => e.CliValorrecargo)
                .HasColumnType("FLOAT")
                .HasColumnName("CLI_VALORRECARGO");
            entity.Property(e => e.CliZona)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("CLI_ZONA");
            entity.Property(e => e.ConCodigo1)
                .HasMaxLength(35)
                .IsUnicode(false)
                .HasColumnName("CON_CODIGO1");
            entity.Property(e => e.ConCodigo2)
                .HasMaxLength(35)
                .IsUnicode(false)
                .HasColumnName("CON_CODIGO2");
            entity.Property(e => e.DepCodigo)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("DEP_CODIGO");
            entity.Property(e => e.EncffaCodigo)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("ENCFFA_CODIGO");
            entity.Property(e => e.GruCodigo)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("GRU_CODIGO");
            entity.Property(e => e.NomCodigo)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("NOM_CODIGO");
            entity.Property(e => e.TcrCodigo)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("TCR_CODIGO");
            entity.Property(e => e.VenCodigo)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("VEN_CODIGO"); */
        });

        modelBuilder.Entity<VenVhcspcf>(entity =>
        {
            entity.HasKey(e => new { e.VhcspcfCodigo, e.Anio }).HasName("VEN_VHCSPCF_PK11098801647718");

            entity.ToTable("VEN_VHCSPCF");

            entity.HasIndex(e => new { e.EncfacNumero, e.Anio }, "VEN_VHCSPCF_UK21451418000818").IsUnique();

            entity.Property(e => e.VhcspcfCodigo)
                .HasColumnType("NUMBER")
                .HasColumnName("VHCSPCF_CODIGO");
            entity.Property(e => e.Anio)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("ANIO");
            entity.Property(e => e.ComCodigo)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("COM_CODIGO");
            entity.Property(e => e.EncfacComcodigo)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("ENCFAC_COMCODIGO");
            entity.Property(e => e.EncfacNumero)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ENCFAC_NUMERO");
            entity.Property(e => e.VhcspcfChequeo)
                .HasColumnType("NUMBER")
                .HasColumnName("VHCSPCF_CHEQUEO");
            entity.Property(e => e.VhcspcfColor)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("VHCSPCF_COLOR");
            entity.Property(e => e.VhcspcfMarca)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("VHCSPCF_MARCA");
            entity.Property(e => e.VhcspcfMarcaDescrip)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("VHCSPCF_MARCA_DESCRIP");
            entity.Property(e => e.VhcspcfOrden)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("VHCSPCF_ORDEN");
            entity.Property(e => e.VhcspcfPlaca)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("VHCSPCF_PLACA");
            entity.Property(e => e.VhcspcfTipo)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("VHCSPCF_TIPO");

            entity.HasOne(d => d.VenEncfac).WithMany(p => p.VenVhcspcfs)
                .HasForeignKey(d => new { d.EncfacNumero, d.ComCodigo, d.Anio })
                .HasConstraintName("FK_ENCFAC_NUMERO");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
