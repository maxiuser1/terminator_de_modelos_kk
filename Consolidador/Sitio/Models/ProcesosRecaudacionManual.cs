using System;
using System.Collections.Generic;

namespace Sitio.Models
{
    public partial class ProcesosRecaudacionManual
    {
        public int IdProcesoRecaudacionManual { get; set; }
        public int? IdFormaPago { get; set; }
        public int? CuotaMaxima { get; set; }
        public DateTime Creado { get; set; }
        public DateTime? Modificado { get; set; }
    }
}
