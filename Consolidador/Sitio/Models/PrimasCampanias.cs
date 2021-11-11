using System;
using System.Collections.Generic;

namespace Sitio.Models
{
    public partial class PrimasCampanias
    {
        public int IdPrimaCampania { get; set; }
        public int? IdCampania { get; set; }
        public int? IdTipoVehiculo { get; set; }
        public int? PrimaMinima { get; set; }
        public int? PrimaMaxima { get; set; }
        public int? PrimaTecnica { get; set; }
        public int? TasaCambio { get; set; }
        public int? MontoDescuento { get; set; }
        public int? CantIdadDecimales { get; set; }
        public string NotaMonto { get; set; }
        public int? Estado { get; set; }
        public DateTime Creado { get; set; }
        public DateTime? Modificado { get; set; }
    }
}
