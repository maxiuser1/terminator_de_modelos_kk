using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Sitio.ViewModels;

namespace Sitio.Models
{
    public partial class soapContext : DbContext
    {
        public soapContext()
        {
        }

        public soapContext(DbContextOptions<soapContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AnulacionesSoap> AnulacionesSoap { get; set; }
        public virtual DbSet<Aseguradoras> Aseguradoras { get; set; }
        public virtual DbSet<Campanias> Campanias { get; set; }
        public virtual DbSet<CanalesVentas> CanalesVentas { get; set; }
        public virtual DbSet<Ciudades> Ciudades { get; set; }
        public virtual DbSet<Comunas> Comunas { get; set; }
        public virtual DbSet<Configuracionmodeloventas> Configuracionmodeloventas { get; set; }
        public virtual DbSet<ConfirmacionAach> ConfirmacionAach { get; set; }
        public virtual DbSet<ConjuntosVentaSoap> ConjuntosVentaSoap { get; set; }
        public virtual DbSet<Contratantes> Contratantes { get; set; }
        public virtual DbSet<ControlesHtml> ControlesHtml { get; set; }
        public virtual DbSet<DatosPrecargadoEmpresa> DatosPrecargadoEmpresa { get; set; }
        public virtual DbSet<DetalleAnulaciones> DetalleAnulaciones { get; set; }
        public virtual DbSet<EmisionPolizasPorSoporte> EmisionPolizasPorSoporte { get; set; }
        public virtual DbSet<Empresas> Empresas { get; set; }
        public virtual DbSet<Folios> Folios { get; set; }
        public virtual DbSet<FormasPagos> FormasPagos { get; set; }
        public virtual DbSet<HomologacionPatentes> HomologacionPatentes { get; set; }
        public virtual DbSet<HomologacionPatentesMotos> HomologacionPatentesMotos { get; set; }
        public virtual DbSet<HomologacionesRegla> HomologacionesRegla { get; set; }
        public virtual DbSet<IntencionesConjuntoVentaSoap> IntencionesConjuntoVentaSoap { get; set; }
        public virtual DbSet<IntencionesVentaSoap> IntencionesVentaSoap { get; set; }
        public virtual DbSet<Marcas> Marcas { get; set; }
        public virtual DbSet<Modelos> Modelos { get; set; }
        public virtual DbSet<ModelosVentas> ModelosVentas { get; set; }
        public virtual DbSet<Modulos> Modulos { get; set; }
        public virtual DbSet<Montos> Montos { get; set; }
        public virtual DbSet<PagoOrdenesCompra> PagoOrdenesCompra { get; set; }
        public virtual DbSet<Patentes> Patentes { get; set; }
        public virtual DbSet<Perfiles> Perfiles { get; set; }
        public virtual DbSet<PerfilesModuloSubmodulos> PerfilesModuloSubmodulos { get; set; }
        public virtual DbSet<PlantillasModelo> PlantillasModelo { get; set; }
        public virtual DbSet<PolizaSoap> PolizaSoap { get; set; }
        public virtual DbSet<Polizas> Polizas { get; set; }
        public virtual DbSet<PrimasCampanias> PrimasCampanias { get; set; }
        public virtual DbSet<PrimasSoap> PrimasSoap { get; set; }
        public virtual DbSet<ProcesosEmision> ProcesosEmision { get; set; }
        public virtual DbSet<ProcesosIngreso> ProcesosIngreso { get; set; }
        public virtual DbSet<ProcesosRecaudacionManual> ProcesosRecaudacionManual { get; set; }
        public virtual DbSet<ProcesosRecaudacionOnline> ProcesosRecaudacionOnline { get; set; }
        public virtual DbSet<ProcesosVentaMasiva> ProcesosVentaMasiva { get; set; }
        public virtual DbSet<ProcesosVentaOnline> ProcesosVentaOnline { get; set; }
        public virtual DbSet<Propietarios> Propietarios { get; set; }
        public virtual DbSet<Propuestas> Propuestas { get; set; }
        public virtual DbSet<Regiones> Regiones { get; set; }
        public virtual DbSet<Reglas> Reglas { get; set; }
        public virtual DbSet<RelacionFormaPagoOnline> RelacionFormaPagoOnline { get; set; }
        public virtual DbSet<ResponsablePago> ResponsablePago { get; set; }
        public virtual DbSet<SubModulos> SubModulos { get; set; }
        public virtual DbSet<Sucursales> Sucursales { get; set; }
        public virtual DbSet<TagsHtml> TagsHtml { get; set; }
        public virtual DbSet<TiposVehiculos> TiposVehiculos { get; set; }
        public virtual DbSet<Usuarios> Usuarios { get; set; }
        public virtual DbSet<Vehiculos> Vehiculos { get; set; }
        public virtual DbSet<VentasConPropuesta> VentasConPropuesta { get; set; }
        public virtual DbSet<VentasOnline> VentasOnline { get; set; }
        public virtual DbSet<VentasSoap> VentasSoap { get; set; }

        public virtual DbQuery<ItemModelo> ItemsModelo { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=localhost;Database=soap;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AnulacionesSoap>(entity =>
            {
                entity.HasKey(e => e.IdAnulacionSoap)
                    .HasName("PK__Anulacio__B95E87227F60ED59");

                entity.Property(e => e.Creado).HasColumnType("datetime");

                entity.Property(e => e.FechaAnulacion).HasColumnType("datetime");

                entity.Property(e => e.IdventaSoap).HasColumnName("IDventaSoap");

                entity.Property(e => e.Modificado).HasColumnType("datetime");
            });

            modelBuilder.Entity<Aseguradoras>(entity =>
            {
                entity.HasKey(e => e.IdAseguradora)
                    .HasName("PK__Asegurad__8FA1C59703317E3D");

                entity.Property(e => e.Bloque).IsUnicode(false);

                entity.Property(e => e.Calle).IsUnicode(false);

                entity.Property(e => e.Creado).HasColumnType("datetime");

                entity.Property(e => e.DigitoVerificador).IsUnicode(false);

                entity.Property(e => e.Modificado).HasColumnType("datetime");

                entity.Property(e => e.Nombre).IsUnicode(false);

                entity.Property(e => e.Nota).IsUnicode(false);

                entity.Property(e => e.Telefono).IsUnicode(false);
            });

            modelBuilder.Entity<Campanias>(entity =>
            {
                entity.HasKey(e => e.IdCampania)
                    .HasName("PK__Campania__3303F8760AD2A005");

                entity.Property(e => e.Creado).HasColumnType("datetime");

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.FechaVigenciaDesde).HasColumnType("datetime");

                entity.Property(e => e.FechaVigenciaHasta).HasColumnType("datetime");

                entity.Property(e => e.Modificado).HasColumnType("datetime");

                entity.Property(e => e.Nombre).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);

                entity.Property(e => e.TipoCampania).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<CanalesVentas>(entity =>
            {
                entity.HasKey(e => e.IdCanalVenta)
                    .HasName("PK__CanalesV__E1328C690EA330E9");

                entity.Property(e => e.Bloque).IsUnicode(false);

                entity.Property(e => e.Calle).IsUnicode(false);

                entity.Property(e => e.Creado).HasColumnType("datetime");

                entity.Property(e => e.DigitoVerificador)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Modificado).HasColumnType("datetime");

                entity.Property(e => e.Nombre).IsUnicode(false);

                entity.Property(e => e.Nota).IsUnicode(false);

                entity.Property(e => e.Telefono).IsUnicode(false);
            });

            modelBuilder.Entity<Ciudades>(entity =>
            {
                entity.HasKey(e => e.CiudadId)
                    .HasName("PK__Ciudades__E826E7705F492382");

                entity.Property(e => e.CiudadId).ValueGeneratedNever();

                entity.Property(e => e.Creado).HasColumnType("datetime");

                entity.Property(e => e.Descripcion).IsUnicode(false);

                entity.Property(e => e.Modificado).HasColumnType("datetime");
            });

            modelBuilder.Entity<Comunas>(entity =>
            {
                entity.HasKey(e => e.ComunaId)
                    .HasName("PK__Comunas__4F2DF63F6319B466");

                entity.Property(e => e.ComunaId).ValueGeneratedNever();

                entity.Property(e => e.Creado).HasColumnType("datetime");

                entity.Property(e => e.Descripcion).IsUnicode(false);

                entity.Property(e => e.Modificado).HasColumnType("datetime");
            });

            modelBuilder.Entity<Configuracionmodeloventas>(entity =>
            {
                entity.HasKey(e => e.Idconfiguracionmodeloventa)
                    .HasName("PK_CONFIGURACIONESMODELOVENTAS");

                entity.ToTable("CONFIGURACIONMODELOVENTAS");

                entity.Property(e => e.Idconfiguracionmodeloventa).HasColumnName("IDCONFIGURACIONMODELOVENTA");

                entity.Property(e => e.Creado).HasColumnType("datetime");

                entity.Property(e => e.Estado).HasColumnName("ESTADO");

                entity.Property(e => e.Habilitaasignacionusuario).HasColumnName("HABILITAASIGNACIONUSUARIO");

                entity.Property(e => e.Habilitaediciontipovehiculo).HasColumnName("HABILITAEDICIONTIPOVEHICULO");

                entity.Property(e => e.Idcanalventa).HasColumnName("IDCANALVENTA");

                entity.Property(e => e.Idempresa).HasColumnName("IDEMPRESA");

                entity.Property(e => e.Idmodeloventa).HasColumnName("IDMODELOVENTA");

                entity.Property(e => e.Idplantillamodelo).HasColumnName("IDPLANTILLAMODELO");

                entity.Property(e => e.Idprocesoemision).HasColumnName("IDPROCESOEMISION");

                entity.Property(e => e.Idprocesoingreso).HasColumnName("IDPROCESOINGRESO");

                entity.Property(e => e.Idprocesorecaudacionmanual).HasColumnName("IDPROCESORECAUDACIONMANUAL");

                entity.Property(e => e.Idprocesorecaudaciononline).HasColumnName("IDPROCESORECAUDACIONONLINE");

                entity.Property(e => e.Idprocesoventamasiva).HasColumnName("IDPROCESOVENTAMASIVA");

                entity.Property(e => e.Idprocesoventaonline).HasColumnName("IDPROCESOVENTAONLINE");

                entity.Property(e => e.Modificado).HasColumnType("datetime");

                entity.Property(e => e.Tipopago).HasColumnName("TIPOPAGO");

                entity.Property(e => e.Urlbannerempresa)
                    .HasColumnName("URLBANNEREMPRESA")
                    .IsUnicode(false);

                entity.Property(e => e.Urlretorno)
                    .HasColumnName("URLRETORNO")
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ConfirmacionAach>(entity =>
            {
                entity.HasKey(e => e.IdConfirmacionAach)
                    .HasName("PK__Confirma__167337661B0907CE");

                entity.Property(e => e.Clave)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoError)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Creado).HasColumnType("datetime");

                entity.Property(e => e.DigitoVerificadorPatente)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.FechaAnulacion).HasColumnType("datetime");

                entity.Property(e => e.FechaInicio).HasColumnType("datetime");

                entity.Property(e => e.FechaTermino).HasColumnType("datetime");

                entity.Property(e => e.MarcaVehiculo).IsUnicode(false);

                entity.Property(e => e.MensajeError).IsUnicode(false);

                entity.Property(e => e.ModeloVehiculo).IsUnicode(false);

                entity.Property(e => e.Modificado).HasColumnType("datetime");

                entity.Property(e => e.NombrePropietario).IsUnicode(false);

                entity.Property(e => e.NumeroFolio)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroMotor)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.Patente)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.RutCompania)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RutPropietario)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.Ticket).IsUnicode(false);

                entity.Property(e => e.TipoVehiculo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Usuario)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ConjuntosVentaSoap>(entity =>
            {
                entity.HasKey(e => e.IdConjuntoVentaSoap)
                    .HasName("PK__Conjunto__A2EFD5671ED998B2");

                entity.Property(e => e.Creado).HasColumnType("datetime");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.Modificado).HasColumnType("datetime");
            });

            modelBuilder.Entity<Contratantes>(entity =>
            {
                entity.HasKey(e => e.IdContratante)
                    .HasName("PK__Contrata__5CCE50B522AA2996");

                entity.Property(e => e.ApellIdoMaterno).IsUnicode(false);

                entity.Property(e => e.ApellIdoPaterno).IsUnicode(false);

                entity.Property(e => e.Bloque).IsUnicode(false);

                entity.Property(e => e.Calle).IsUnicode(false);

                entity.Property(e => e.Creado).HasColumnType("datetime");

                entity.Property(e => e.DigitoVerificador)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Email).IsUnicode(false);

                entity.Property(e => e.FechaNacimiento).HasColumnType("datetime");

                entity.Property(e => e.Modificado).HasColumnType("datetime");

                entity.Property(e => e.Nombre).IsUnicode(false);

                entity.Property(e => e.Nota).IsUnicode(false);

                entity.Property(e => e.Telefono).IsUnicode(false);
            });

            modelBuilder.Entity<ControlesHtml>(entity =>
            {
                entity.HasKey(e => e.IdControl)
                    .HasName("PK__CONTROLE__2537521F2BC97F7C");

                entity.Property(e => e.Creado).HasColumnType("datetime");

                entity.Property(e => e.LabelHtml).IsUnicode(false);

                entity.Property(e => e.Modificado).HasColumnType("datetime");

                entity.Property(e => e.TagHtml).IsUnicode(false);
            });

            modelBuilder.Entity<DatosPrecargadoEmpresa>(entity =>
            {
                entity.HasKey(e => e.IdDatosPrecargadoEmpresa)
                    .HasName("PK__DatosPre__397082D0267ABA7A");

                entity.Property(e => e.ApellIdoMaterno).IsUnicode(false);

                entity.Property(e => e.ApellIdoPaterno).IsUnicode(false);

                entity.Property(e => e.Clave).IsUnicode(false);

                entity.Property(e => e.Creado).HasColumnType("datetime");

                entity.Property(e => e.DigitoVerificador)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.EstadoVoucher)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.Modificado).HasColumnType("datetime");

                entity.Property(e => e.Nombre).IsUnicode(false);

                entity.Property(e => e.NumeroPatente)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Pin).IsUnicode(false);
            });

            modelBuilder.Entity<DetalleAnulaciones>(entity =>
            {
                entity.HasKey(e => e.IdDetalleAnulacion)
                    .HasName("PK__DetalleA__C27278FC2A4B4B5E");

                entity.Property(e => e.Creado).HasColumnType("datetime");

                entity.Property(e => e.FechaIngreso).HasColumnType("datetime");

                entity.Property(e => e.Modificado).HasColumnType("datetime");

                entity.Property(e => e.Motivo).IsUnicode(false);
            });

            modelBuilder.Entity<EmisionPolizasPorSoporte>(entity =>
            {
                entity.HasKey(e => e.NumeroPoliza)
                    .HasName("PK__EmisionP__38B3102017C286CF");

                entity.Property(e => e.Creado).HasColumnType("datetime");

                entity.Property(e => e.Modificado).HasColumnType("datetime");

                entity.Property(e => e.NombreArchivo).IsUnicode(false);

                entity.Property(e => e.NombreBanco).IsUnicode(false);
            });

            modelBuilder.Entity<Empresas>(entity =>
            {
                entity.HasKey(e => e.IdEmpresa)
                    .HasName("PK__Empresas__5EF4033E2E1BDC42");

                entity.Property(e => e.Bloque).IsUnicode(false);

                entity.Property(e => e.Calle).IsUnicode(false);

                entity.Property(e => e.Creado).HasColumnType("datetime");

                entity.Property(e => e.DigitoVerificador)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Modificado).HasColumnType("datetime");

                entity.Property(e => e.Nombre).IsUnicode(false);

                entity.Property(e => e.Nota).IsUnicode(false);

                entity.Property(e => e.Telefono)
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Folios>(entity =>
            {
                entity.HasKey(e => e.IdFolio)
                    .HasName("PK__Folios__FFE7DA348BEEADCA");

                entity.Property(e => e.Creado).HasColumnType("datetime");

                entity.Property(e => e.FechaVigenciaDesde).HasColumnType("datetime");

                entity.Property(e => e.FechaVigenciaHasta).HasColumnType("datetime");

                entity.Property(e => e.Modificado).HasColumnType("datetime");

                entity.Property(e => e.NumeroFolio).HasColumnType("numeric(18, 0)");
            });

            modelBuilder.Entity<FormasPagos>(entity =>
            {
                entity.HasKey(e => e.IdFormaPago)
                    .HasName("PK__FormasPa__C777CA685A846E65");

                entity.Property(e => e.Creado).HasColumnType("datetime");

                entity.Property(e => e.Modificado).HasColumnType("datetime");

                entity.Property(e => e.Nombre).IsUnicode(false);
            });

            modelBuilder.Entity<HomologacionPatentes>(entity =>
            {
                entity.HasKey(e => e.IdHomologacionPatente)
                    .HasName("PK__Homologa__22EC60B4412EB0B6");

                entity.Property(e => e.IdHomologacionPatente).ValueGeneratedNever();

                entity.Property(e => e.Creado).HasColumnType("datetime");

                entity.Property(e => e.FechaIngreso).HasColumnType("datetime");

                entity.Property(e => e.LetrasPatente)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Modificado).HasColumnType("datetime");

                entity.Property(e => e.UrlEvIdencia).IsUnicode(false);
            });

            modelBuilder.Entity<HomologacionPatentesMotos>(entity =>
            {
                entity.Property(e => e.Creado).HasColumnType("datetime");

                entity.Property(e => e.Letra)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Modificado)
                    .HasMaxLength(10)
                    .IsFixedLength();
            });

            modelBuilder.Entity<HomologacionesRegla>(entity =>
            {
                entity.HasKey(e => e.IdHomologacionRegla)
                    .HasName("PK__Homologa__D99A76FD3D5E1FD2");

                entity.Property(e => e.Creado).HasColumnType("datetime");

                entity.Property(e => e.Descripcion).IsUnicode(false);

                entity.Property(e => e.Modificado).HasColumnType("datetime");
            });

            modelBuilder.Entity<IntencionesConjuntoVentaSoap>(entity =>
            {
                entity.HasKey(e => e.IdintencionConjuntoVentaSoap)
                    .HasName("PK__intencio__A7CFF6674D94879B");

                entity.ToTable("intencionesConjuntoVentaSoap");

                entity.Property(e => e.Creado).HasColumnType("datetime");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.Modificado).HasColumnType("datetime");

                entity.Property(e => e.NumeroDeComprobante).IsUnicode(false);

                entity.Property(e => e.NumeroDeTarjeta).IsUnicode(false);
            });

            modelBuilder.Entity<IntencionesVentaSoap>(entity =>
            {
                entity.HasKey(e => e.IdIntencionVentaSoap)
                    .HasName("PK__Intencio__9E4625965165187F");

                entity.Property(e => e.Creado).HasColumnType("datetime");

                entity.Property(e => e.FechaVenta).HasColumnType("datetime");

                entity.Property(e => e.Idvehiculo).HasColumnName("IDvehiculo");

                entity.Property(e => e.Modificado).HasColumnType("datetime");
            });

            modelBuilder.Entity<Marcas>(entity =>
            {
                entity.HasKey(e => e.IdMarca)
                    .HasName("PK__Marcas__4076A8877DCDAAA2");

                entity.Property(e => e.Creado).HasColumnType("datetime");

                entity.Property(e => e.Modificado).HasColumnType("datetime");

                entity.Property(e => e.Nombre).IsUnicode(false);
            });

            modelBuilder.Entity<Modelos>(entity =>
            {
                entity.HasKey(e => e.IdModelo)
                    .HasName("PK__Modelos__CC30D30C019E3B86");

                entity.Property(e => e.Creado).HasColumnType("datetime");

                entity.Property(e => e.Modificado).HasColumnType("datetime");

                entity.Property(e => e.Nombre).IsUnicode(false);
            });

            modelBuilder.Entity<ModelosVentas>(entity =>
            {
                entity.HasKey(e => e.IdModeloVenta)
                    .HasName("PK__ModelosV__2C6373264F6F1E15");

                entity.Property(e => e.Creado).HasColumnType("datetime");

                entity.Property(e => e.Modificado).HasColumnType("datetime");

                entity.Property(e => e.Nombre).IsUnicode(false);
            });

            modelBuilder.Entity<Modulos>(entity =>
            {
                entity.HasKey(e => e.IdModulo)
                    .HasName("PK__Modulos__D9F15315336AA144");

                entity.Property(e => e.Creado).HasColumnType("datetime");

                entity.Property(e => e.Modificado).HasColumnType("datetime");

                entity.Property(e => e.Nombre).IsUnicode(false);
            });

            modelBuilder.Entity<Montos>(entity =>
            {
                entity.HasKey(e => e.IdMonto)
                    .HasName("PK__Montos__C27D9C577B5B524B");

                entity.Property(e => e.Creado).HasColumnType("datetime");

                entity.Property(e => e.Modificado).HasColumnType("datetime");

                entity.Property(e => e.NotaMonto).IsUnicode(false);
            });

            modelBuilder.Entity<PagoOrdenesCompra>(entity =>
            {
                entity.HasKey(e => e.IntencionConjuntoVentaSoapId)
                    .HasName("PK_PagoOrdenesCompra_1");

                entity.Property(e => e.IntencionConjuntoVentaSoapId)
                    .HasColumnName("IntencionConjuntoVentaSoap_Id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Creado).HasColumnType("datetime");

                entity.Property(e => e.TipoPago)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Patentes>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Letras)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Numeros)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Perfiles>(entity =>
            {
                entity.HasKey(e => e.IdPerfil)
                    .HasName("PK__Perfiles__C7BD5CC13BFFE745");

                entity.Property(e => e.Creado).HasColumnType("datetime");

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.Modificado).HasColumnType("datetime");

                entity.Property(e => e.Nombre).IsUnicode(false);
            });

            modelBuilder.Entity<PerfilesModuloSubmodulos>(entity =>
            {
                entity.HasKey(e => e.IdPerfilModulo)
                    .HasName("PK__Perfiles__97287C35373B3228");

                entity.Property(e => e.Creado).HasColumnType("datetime");

                entity.Property(e => e.Modificado).HasColumnType("datetime");
            });

            modelBuilder.Entity<PlantillasModelo>(entity =>
            {
                entity.HasKey(e => e.IdPlantillaModelo)
                    .HasName("PK__Plantill__85AEB7C6725BF7F6");

                entity.Property(e => e.Creado).HasColumnType("datetime");

                entity.Property(e => e.Modificado).HasColumnType("datetime");

                entity.Property(e => e.Nombre).IsUnicode(false);
            });

            modelBuilder.Entity<PolizaSoap>(entity =>
            {
                entity.HasKey(e => e.IdPolizaSoap)
                    .HasName("PK__PolizaSo__8F5564506D4566F5");

                entity.Property(e => e.AbreviacionElectronica)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Creado).HasColumnType("datetime");

                entity.Property(e => e.FechaEmision).HasColumnType("datetime");

                entity.Property(e => e.Modificado).HasColumnType("datetime");

                entity.Property(e => e.NumeroFolio).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.NumeroPoliza).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.UrlPolizaSoap)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.VigenciaDesde).HasColumnType("datetime");

                entity.Property(e => e.VigenciaHasta).HasColumnType("datetime");
            });

            modelBuilder.Entity<Polizas>(entity =>
            {
                entity.HasKey(e => e.IdPoliza)
                    .HasName("PK__Polizas__8E3943B3E9435B02");

                entity.Property(e => e.Creado).HasColumnType("datetime");

                entity.Property(e => e.DigitoVerificadorPoliza)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.FechaVigenciaDesde).HasColumnType("datetime");

                entity.Property(e => e.FechaVigenciaHasta).HasColumnType("datetime");

                entity.Property(e => e.Modificado).HasColumnType("datetime");

                entity.Property(e => e.NumeroPoliza).HasColumnType("numeric(18, 0)");
            });

            modelBuilder.Entity<PrimasCampanias>(entity =>
            {
                entity.HasKey(e => e.IdPrimaCampania)
                    .HasName("PK__PrimasCa__B9AF5B1C477199F1");

                entity.Property(e => e.Creado).HasColumnType("datetime");

                entity.Property(e => e.Modificado).HasColumnType("datetime");

                entity.Property(e => e.NotaMonto).IsUnicode(false);
            });

            modelBuilder.Entity<PrimasSoap>(entity =>
            {
                entity.HasKey(e => e.IdPrimaSoap)
                    .HasName("PK__PrimasSo__495418A743A1090D");

                entity.Property(e => e.Creado).HasColumnType("datetime");

                entity.Property(e => e.Modificado).HasColumnType("datetime");
            });

            modelBuilder.Entity<ProcesosEmision>(entity =>
            {
                entity.HasKey(e => e.IdProcesoEmision)
                    .HasName("PK__Procesos__B664CFAB18EBB532");

                entity.Property(e => e.Creado).HasColumnType("datetime");

                entity.Property(e => e.Modificado).HasColumnType("datetime");

                entity.Property(e => e.Urlagina).IsUnicode(false);
            });

            modelBuilder.Entity<ProcesosIngreso>(entity =>
            {
                entity.HasKey(e => e.IdProcesoIngreso)
                    .HasName("PK__Procesos__497E59BF1CBC4616");

                entity.Property(e => e.Creado).HasColumnType("datetime");

                entity.Property(e => e.LogoUrlImagen).IsUnicode(false);

                entity.Property(e => e.Modificado).HasColumnType("datetime");
            });

            modelBuilder.Entity<ProcesosRecaudacionManual>(entity =>
            {
                entity.HasKey(e => e.IdProcesoRecaudacionManual)
                    .HasName("PK__Procesos__2A5B8DE9208CD6FA");

                entity.Property(e => e.Creado).HasColumnType("datetime");

                entity.Property(e => e.Modificado).HasColumnType("datetime");
            });

            modelBuilder.Entity<ProcesosRecaudacionOnline>(entity =>
            {
                entity.HasKey(e => e.IdProcesoRecaudacionOnline)
                    .HasName("PK__Procesos__47E9B30D52E34C9D");

                entity.Property(e => e.Creado).HasColumnType("datetime");

                entity.Property(e => e.Modificado).HasColumnType("datetime");
            });

            modelBuilder.Entity<ProcesosVentaMasiva>(entity =>
            {
                entity.HasKey(e => e.IdProcesoVentaMasiva)
                    .HasName("PK__Procesos__1097D2AC282DF8C2");

                entity.Property(e => e.Creado).HasColumnType("datetime");

                entity.Property(e => e.Modificado).HasColumnType("datetime");

                entity.Property(e => e.UrlPagina).IsUnicode(false);
            });

            modelBuilder.Entity<ProcesosVentaOnline>(entity =>
            {
                entity.HasKey(e => e.IdProcesoVentaOnline)
                    .HasName("PK__Procesos__BD333FEA2BFE89A6");

                entity.Property(e => e.Creado).HasColumnType("datetime");

                entity.Property(e => e.Modificado).HasColumnType("datetime");

                entity.Property(e => e.UrlPagina).IsUnicode(false);
            });

            modelBuilder.Entity<Propietarios>(entity =>
            {
                entity.HasKey(e => e.IdPropietario)
                    .HasName("PK__Propieta__4D581B502FCF1A8A");

                entity.Property(e => e.ApellIdoMaterno).IsUnicode(false);

                entity.Property(e => e.ApellIdoPaterno).IsUnicode(false);

                entity.Property(e => e.Bloque)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Calle).IsUnicode(false);

                entity.Property(e => e.Creado).HasColumnType("datetime");

                entity.Property(e => e.DigitoVerificador)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Email).IsUnicode(false);

                entity.Property(e => e.FechaNacimiento).HasColumnType("datetime");

                entity.Property(e => e.Modificado).HasColumnType("datetime");

                entity.Property(e => e.Nombre).IsUnicode(false);

                entity.Property(e => e.Nota).IsUnicode(false);

                entity.Property(e => e.Telefono)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Propuestas>(entity =>
            {
                entity.HasKey(e => e.IdPropuestas)
                    .HasName("PK__Propuest__53E3518A339FAB6E");

                entity.Property(e => e.ApellIdoMaterno).IsUnicode(false);

                entity.Property(e => e.ApellIdoPaterno).IsUnicode(false);

                entity.Property(e => e.Creado).HasColumnType("datetime");

                entity.Property(e => e.DigitoVerificador)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.Mail).IsUnicode(false);

                entity.Property(e => e.Modificado).HasColumnType("datetime");

                entity.Property(e => e.Nombre).IsUnicode(false);

                entity.Property(e => e.NumeroMotor).IsUnicode(false);

                entity.Property(e => e.NumeroPatente)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Telefono)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Regiones>(entity =>
            {
                entity.HasKey(e => e.RegionId)
                    .HasName("PK__Regiones__ACD844A366EA454A");

                entity.Property(e => e.RegionId).ValueGeneratedNever();

                entity.Property(e => e.Creado).HasColumnType("datetime");

                entity.Property(e => e.Descripcion).IsUnicode(false);

                entity.Property(e => e.DescripcionCorta).IsUnicode(false);

                entity.Property(e => e.Modificado).HasColumnType("datetime");
            });

            modelBuilder.Entity<Reglas>(entity =>
            {
                entity.HasKey(e => e.IdRegla)
                    .HasName("PK__Reglas__E4F53D614F12BBB9");

                entity.Property(e => e.Creado).HasColumnType("datetime");

                entity.Property(e => e.Modificado).HasColumnType("datetime");
            });

            modelBuilder.Entity<RelacionFormaPagoOnline>(entity =>
            {
                entity.HasKey(e => e.IdRelacionFormaPagoOnline)
                    .HasName("PK__Relacion__19A5E53546B27FE2");

                entity.Property(e => e.Creado).HasColumnType("datetime");

                entity.Property(e => e.Modificado).HasColumnType("datetime");
            });

            modelBuilder.Entity<ResponsablePago>(entity =>
            {
                entity.HasKey(e => e.IdResponsablePago)
                    .HasName("PK__Responsa__4F4940764A8310C6");

                entity.Property(e => e.ApellIdoMaterno).IsUnicode(false);

                entity.Property(e => e.ApellIdoPaterno).IsUnicode(false);

                entity.Property(e => e.Bloque)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Calle).IsUnicode(false);

                entity.Property(e => e.Creado).HasColumnType("datetime");

                entity.Property(e => e.DigitoVerificador)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Email).IsUnicode(false);

                entity.Property(e => e.FechaNacimiento).HasColumnType("datetime");

                entity.Property(e => e.Modificado).HasColumnType("datetime");

                entity.Property(e => e.Nombre).IsUnicode(false);

                entity.Property(e => e.NombreCiudad)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NombreComuna)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Nota).IsUnicode(false);

                entity.Property(e => e.Telefono)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SubModulos>(entity =>
            {
                entity.HasKey(e => e.IdSubmodulo)
                    .HasName("PK__SubModul__86C24868762C88DA");

                entity.Property(e => e.Creado).HasColumnType("datetime");

                entity.Property(e => e.Modificado).HasColumnType("datetime");

                entity.Property(e => e.Nombre).IsUnicode(false);

                entity.Property(e => e.NombreControlador).IsUnicode(false);

                entity.Property(e => e.Url).IsUnicode(false);
            });

            modelBuilder.Entity<Sucursales>(entity =>
            {
                entity.HasKey(e => e.IdSucursal)
                    .HasName("PK__Sucursal__BFB6CD995224328E");

                entity.Property(e => e.Creado).HasColumnType("datetime");

                entity.Property(e => e.Modificado).HasColumnType("datetime");

                entity.Property(e => e.Nombre).IsUnicode(false);
            });

            modelBuilder.Entity<TagsHtml>(entity =>
            {
                entity.HasKey(e => e.IdTagHtml)
                    .HasName("PK__TagsHtml__0804C2BD55F4C372");

                entity.Property(e => e.Creado).HasColumnType("datetime");

                entity.Property(e => e.InnerHtml).IsUnicode(false);

                entity.Property(e => e.LabelHtml).IsUnicode(false);

                entity.Property(e => e.Modificado).HasColumnType("datetime");

                entity.Property(e => e.TipoDato)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TiposVehiculos>(entity =>
            {
                entity.HasKey(e => e.IdTipoVehiculo)
                    .HasName("PK__TiposVeh__DC20741E79FD19BE");

                entity.Property(e => e.Alias).IsUnicode(false);

                entity.Property(e => e.Creado).HasColumnType("datetime");

                entity.Property(e => e.Modificado).HasColumnType("datetime");

                entity.Property(e => e.Nombre).IsUnicode(false);
            });

            modelBuilder.Entity<Usuarios>(entity =>
            {
                entity.HasKey(e => e.IdUsuario)
                    .HasName("PK__Usuarios__5B65BF97671F4F74");

                entity.Property(e => e.ApellidoMaterno).IsUnicode(false);

                entity.Property(e => e.ApellidoPaterno).IsUnicode(false);

                entity.Property(e => e.Bloque)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Calle).IsUnicode(false);

                entity.Property(e => e.Contrasenia)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Creado).HasColumnType("datetime");

                entity.Property(e => e.DigitoVerificador)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Email).IsUnicode(false);

                entity.Property(e => e.FechaNacimiento).HasColumnType("datetime");

                entity.Property(e => e.Login).IsUnicode(false);

                entity.Property(e => e.Modificado).HasColumnType("datetime");

                entity.Property(e => e.Nombre).IsUnicode(false);

                entity.Property(e => e.Nota).IsUnicode(false);

                entity.Property(e => e.Telefono)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Vehiculos>(entity =>
            {
                entity.HasKey(e => e.Idvehiculo)
                    .HasName("PK__Vehiculo__07A855366EC0713C");

                entity.Property(e => e.Idvehiculo).HasColumnName("IDvehiculo");

                entity.Property(e => e.Creado).HasColumnType("datetime");

                entity.Property(e => e.DigitoVerificadorPatente)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Modificado).HasColumnType("datetime");

                entity.Property(e => e.NumeroMotor).IsUnicode(false);

                entity.Property(e => e.NumeroPatente)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VentasConPropuesta>(entity =>
            {
                entity.HasKey(e => e.NumeroPropuesta)
                    .HasName("PK__VentasCo__F208879E10216507");

                entity.Property(e => e.Creado).HasColumnType("datetime");

                entity.Property(e => e.Modificado).HasColumnType("datetime");

                entity.Property(e => e.Patente)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VentasOnline>(entity =>
            {
                entity.HasKey(e => e.IdventaOnline)
                    .HasName("PK__VentasOn__6A20886D7B264821");

                entity.Property(e => e.IdventaOnline).HasColumnName("IDventaOnline");

                entity.Property(e => e.Creado).HasColumnType("datetime");

                entity.Property(e => e.Modificado).HasColumnType("datetime");
            });

            modelBuilder.Entity<VentasSoap>(entity =>
            {
                entity.HasKey(e => e.IdventaSoap)
                    .HasName("PK__VentasSo__CAEB39827EF6D905");

                entity.Property(e => e.IdventaSoap).HasColumnName("IDventaSoap");

                entity.Property(e => e.Creado).HasColumnType("datetime");

                entity.Property(e => e.FechaVenta).HasColumnType("datetime");

                entity.Property(e => e.Idvehiculo).HasColumnName("IDvehiculo");

                entity.Property(e => e.Modificado).HasColumnType("datetime");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
