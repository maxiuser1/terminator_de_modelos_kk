using System;
using System.Collections.Generic;

namespace Sitio.Models
{
    public partial class Modelos
    {
        public int IdModelo { get; set; }
        public int? IdMarca { get; set; }
        public string Nombre { get; set; }
        public int? IdTipoVehiculo { get; set; }
        public int? Estado { get; set; }
        public DateTime Creado { get; set; }
        public DateTime? Modificado { get; set; }
    }
}
