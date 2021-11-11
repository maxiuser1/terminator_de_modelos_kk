using System;
using System.Collections.Generic;

namespace Sitio.Models
{
    public partial class Reglas
    {
        public int IdRegla { get; set; }
        public int IdProcesoVentaOnline { get; set; }
        public int? Codigo { get; set; }
        public int? Valor { get; set; }
        public int? EstadoRegla { get; set; }
        public DateTime Creado { get; set; }
        public DateTime? Modificado { get; set; }
    }
}
