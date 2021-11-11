using System;
using System.Collections.Generic;

namespace Sitio.Models
{
    public partial class SubModulos
    {
        public int IdSubmodulo { get; set; }
        public string Nombre { get; set; }
        public string Url { get; set; }
        public int? IdModuloPadre { get; set; }
        public string NombreControlador { get; set; }
        public DateTime Creado { get; set; }
        public DateTime? Modificado { get; set; }
    }
}
