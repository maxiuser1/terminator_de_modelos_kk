using System;
using System.Collections.Generic;

namespace Sitio.Models
{
    public partial class Folios
    {
        public int IdFolio { get; set; }
        public DateTime? FechaVigenciaDesde { get; set; }
        public DateTime? FechaVigenciaHasta { get; set; }
        public decimal? NumeroFolio { get; set; }
        public int? TipoEstadoNumero { get; set; }
        public DateTime Creado { get; set; }
        public DateTime? Modificado { get; set; }
    }
}
