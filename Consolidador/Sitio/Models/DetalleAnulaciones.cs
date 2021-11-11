using System;
using System.Collections.Generic;

namespace Sitio.Models
{
    public partial class DetalleAnulaciones
    {
        public int IdDetalleAnulacion { get; set; }
        public int? IdAnulacionSoap { get; set; }
        public string Motivo { get; set; }
        public DateTime? FechaIngreso { get; set; }
        public int? Estado { get; set; }
        public int? IdUsuario { get; set; }
        public DateTime Creado { get; set; }
        public DateTime? Modificado { get; set; }
    }
}
