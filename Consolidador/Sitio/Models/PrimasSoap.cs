using System;
using System.Collections.Generic;

namespace Sitio.Models
{
    public partial class PrimasSoap
    {
        public int IdPrimaSoap { get; set; }
        public int? IdMonto { get; set; }
        public DateTime Creado { get; set; }
        public DateTime? Modificado { get; set; }
    }
}
