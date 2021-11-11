using System;
using System.Collections.Generic;

namespace Sitio.Models
{
    public partial class Polizas
    {
        public int IdPoliza { get; set; }
        public DateTime? FechaVigenciaDesde { get; set; }
        public DateTime? FechaVigenciaHasta { get; set; }
        public string DigitoVerificadorPoliza { get; set; }
        public decimal? NumeroPoliza { get; set; }
        public int? TipoEstadoNumero { get; set; }
        public DateTime Creado { get; set; }
        public DateTime? Modificado { get; set; }
    }
}
