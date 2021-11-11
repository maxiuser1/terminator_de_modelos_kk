using System;
using System.Collections.Generic;

namespace Sitio.Models
{
    public partial class VentasSoap
    {
        public int IdventaSoap { get; set; }
        public int? IdPropietario { get; set; }
        public int? IdPrimaSoap { get; set; }
        public int? IdPolizaSoap { get; set; }
        public int? IdResponsablePago { get; set; }
        public int? IdUsuario { get; set; }
        public int? Idvehiculo { get; set; }
        public int? IdSucursal { get; set; }
        public int? IdContratante { get; set; }
        public int? IdFormaPago { get; set; }
        public DateTime? FechaVenta { get; set; }
        public int? Estado { get; set; }
        public int? NumeroCuota { get; set; }
        public int? IdConjuntoVentaSoap { get; set; }
        public int? SeInformoAs400 { get; set; }
        public int? EsDentroCredito { get; set; }
        public int? IdPrimaCampania { get; set; }
        public int? TipoEstadoEnvioVentaSoap { get; set; }
        public int? IdIntencionVentaSoap { get; set; }
        public DateTime Creado { get; set; }
        public DateTime? Modificado { get; set; }
    }
}
