using System;
using System.Collections.Generic;

namespace Sitio.Models
{
    public partial class PagoOrdenesCompra
    {
        public int IntencionConjuntoVentaSoapId { get; set; }
        public int? NumeroOrdenCompra { get; set; }
        public int Monto { get; set; }
        public string TipoPago { get; set; }
        public DateTime Creado { get; set; }
    }
}
