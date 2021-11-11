using System;
using System.Collections.Generic;

namespace Sitio.Models
{
    public partial class Montos
    {
        public int IdMonto { get; set; }
        public int? TasaCambio { get; set; }
        public int? MontoDescuento { get; set; }
        public string NotaMonto { get; set; }
        public int? CantIdadDecimales { get; set; }
        public int? Valor { get; set; }
        public DateTime Creado { get; set; }
        public DateTime? Modificado { get; set; }
    }
}
