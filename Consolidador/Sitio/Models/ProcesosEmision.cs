using System;
using System.Collections.Generic;

namespace Sitio.Models
{
    public partial class ProcesosEmision
    {
        public int IdProcesoEmision { get; set; }
        public string Urlagina { get; set; }
        public int? IdPolizaSoap { get; set; }
        public DateTime Creado { get; set; }
        public DateTime? Modificado { get; set; }
    }
}
