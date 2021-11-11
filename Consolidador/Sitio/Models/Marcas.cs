using System;
using System.Collections.Generic;

namespace Sitio.Models
{
    public partial class Marcas
    {
        public int IdMarca { get; set; }
        public string Nombre { get; set; }
        public int? EsVigente { get; set; }
        public DateTime Creado { get; set; }
        public DateTime? Modificado { get; set; }
    }
}
