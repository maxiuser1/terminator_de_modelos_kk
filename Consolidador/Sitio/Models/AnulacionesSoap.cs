using System;
using System.Collections.Generic;

namespace Sitio.Models
{
    public partial class AnulacionesSoap
    {
        public int IdAnulacionSoap { get; set; }
        public int? IdUsuario { get; set; }
        public DateTime? FechaAnulacion { get; set; }
        public int? DevolucionPrima { get; set; }
        public int? IdventaSoap { get; set; }
        public DateTime Creado { get; set; }
        public DateTime? Modificado { get; set; }
    }
}
