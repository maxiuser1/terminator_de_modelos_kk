using System;
using System.Collections.Generic;

namespace Sitio.Models
{
    public partial class PerfilesModuloSubmodulos
    {
        public int IdPerfilModulo { get; set; }
        public int? IdPerfil { get; set; }
        public int? IdModulo { get; set; }
        public int? IdSubModulo { get; set; }
        public DateTime Creado { get; set; }
        public DateTime? Modificado { get; set; }
    }
}
