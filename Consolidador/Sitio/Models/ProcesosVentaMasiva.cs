using System;
using System.Collections.Generic;

namespace Sitio.Models
{
    public partial class ProcesosVentaMasiva
    {
        public int IdProcesoVentaMasiva { get; set; }
        public string UrlPagina { get; set; }
        public DateTime Creado { get; set; }
        public DateTime? Modificado { get; set; }
    }
}
