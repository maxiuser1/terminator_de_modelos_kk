using System;
using System.Collections.Generic;

namespace Sitio.Models
{
    public partial class ModelosVentas
    {
        public int IdModeloVenta { get; set; }
        public int? Codigo { get; set; }
        public string Nombre { get; set; }
        public DateTime Creado { get; set; }
        public DateTime? Modificado { get; set; }
    }
}
