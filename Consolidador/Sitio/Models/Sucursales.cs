using System;
using System.Collections.Generic;

namespace Sitio.Models
{
    public partial class Sucursales
    {
        public int IdSucursal { get; set; }
        public int? IdEmpresa { get; set; }
        public int? Codigo { get; set; }
        public string Nombre { get; set; }
        public int? Estado { get; set; }
        public DateTime Creado { get; set; }
        public DateTime? Modificado { get; set; }
    }
}
