using System;
using System.Collections.Generic;

namespace Sitio.Models
{
    public partial class TiposVehiculos
    {
        public int IdTipoVehiculo { get; set; }
        public int? Codigo { get; set; }
        public string Nombre { get; set; }
        public int? MesPolizaSoap { get; set; }
        public string Alias { get; set; }
        public DateTime Creado { get; set; }
        public DateTime? Modificado { get; set; }
    }
}
