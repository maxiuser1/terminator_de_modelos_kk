using System;
using System.Collections.Generic;

namespace Sitio.Models
{
    public partial class Perfiles
    {
        public int IdPerfil { get; set; }
        public string Nombre { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public int? NivelDeSegurIdad { get; set; }
        public DateTime Creado { get; set; }
        public DateTime? Modificado { get; set; }
    }
}
