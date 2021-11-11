using System;
using System.Collections.Generic;

namespace Sitio.Models
{
    public partial class VentasConPropuesta
    {
        public int NumeroPropuesta { get; set; }
        public string Patente { get; set; }
        public int? RutEmpresa { get; set; }
        public int? NumeroPoliza { get; set; }
        public int? RutUsuarioPropuesta { get; set; }
        public DateTime Creado { get; set; }
        public DateTime? Modificado { get; set; }
    }
}
