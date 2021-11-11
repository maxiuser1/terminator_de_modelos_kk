using System;
using System.Collections.Generic;

namespace Sitio.Models
{
    public partial class Regiones
    {
        public int RegionId { get; set; }
        public string Descripcion { get; set; }
        public string DescripcionCorta { get; set; }
        public DateTime Creado { get; set; }
        public DateTime? Modificado { get; set; }
    }
}
