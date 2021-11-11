using System;
using System.Collections.Generic;

namespace Sitio.Models
{
    public partial class ProcesosVentaOnline
    {
        public int IdProcesoVentaOnline { get; set; }
        public string UrlPagina { get; set; }
        public int? InicioConBusqueda { get; set; }
        public DateTime Creado { get; set; }
        public DateTime? Modificado { get; set; }
    }
}
