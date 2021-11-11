using System;
using System.Collections.Generic;

namespace Sitio.Models
{
    public partial class ConjuntosVentaSoap
    {
        public int IdConjuntoVentaSoap { get; set; }
        public DateTime? Fecha { get; set; }
        public int? MontoTotal { get; set; }
        public DateTime Creado { get; set; }
        public DateTime? Modificado { get; set; }
    }
}
