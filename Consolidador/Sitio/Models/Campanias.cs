using System;
using System.Collections.Generic;

namespace Sitio.Models
{
    public partial class Campanias
    {
        public int IdCampania { get; set; }
        public int? Codigo { get; set; }
        public string Nombre { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public DateTime? FechaVigenciaDesde { get; set; }
        public DateTime? FechaVigenciaHasta { get; set; }
        public int? RenovacionPermisoCirculacion { get; set; }
        public int? CampaniaVigente { get; set; }
        public int? IdModeloVenta { get; set; }
        public string Status { get; set; }
        public DateTime Creado { get; set; }
        public DateTime? Modificado { get; set; }
        public int? TipoCampania { get; set; }
    }
}
