using System;
using System.Collections.Generic;

namespace Sitio.Models
{
    public partial class RelacionFormaPagoOnline
    {
        public int IdRelacionFormaPagoOnline { get; set; }
        public int? IdProcesoRecaudacionOnline { get; set; }
        public int? IdFormaPago { get; set; }
        public int? FormaPagoActivada { get; set; }
        public DateTime Creado { get; set; }
        public DateTime? Modificado { get; set; }
    }
}
