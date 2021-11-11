using System;
using System.Collections.Generic;

namespace Sitio.Models
{
    public partial class VentasOnline
    {
        public int IdventaOnline { get; set; }
        public int IdResponsablePago { get; set; }
        public DateTime Creado { get; set; }
        public DateTime? Modificado { get; set; }
    }
}
