using System;
using System.Collections.Generic;

namespace Sitio.Models
{
    public partial class ProcesosRecaudacionOnline
    {
        public int IdProcesoRecaudacionOnline { get; set; }
        public int? IdFormapago { get; set; }
        public DateTime Creado { get; set; }
        public DateTime? Modificado { get; set; }
    }
}
