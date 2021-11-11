using System;
using System.Collections.Generic;

namespace Sitio.Models
{
    public partial class Modulos
    {
        public int IdModulo { get; set; }
        public string Nombre { get; set; }
        public int? Orden { get; set; }
        public DateTime Creado { get; set; }
        public DateTime? Modificado { get; set; }
    }
}
