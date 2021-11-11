using System;
using System.Collections.Generic;

namespace Sitio.Models
{
    public partial class IntencionesConjuntoVentaSoap
    {
        public int IdintencionConjuntoVentaSoap { get; set; }
        public DateTime? Fecha { get; set; }
        public int? MontoTotal { get; set; }
        public string NumeroDeTarjeta { get; set; }
        public string NumeroDeComprobante { get; set; }
        public int? NumeroDeCuotas { get; set; }
        public int? ValorCuotas { get; set; }
        public int? EstadoDePago { get; set; }
        public int? ValorDespacho { get; set; }
        public DateTime Creado { get; set; }
        public DateTime? Modificado { get; set; }
    }
}
