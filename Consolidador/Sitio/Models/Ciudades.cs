using System;
using System.Collections.Generic;

namespace Sitio.Models
{
    public partial class Ciudades
    {
        public int CiudadId { get; set; }
        public string Descripcion { get; set; }
        public int? RegionId { get; set; }
        public DateTime Creado { get; set; }
        public DateTime? Modificado { get; set; }
    }
}
