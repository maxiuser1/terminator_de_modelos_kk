using System;
using System.Collections.Generic;

namespace Sitio.Models
{
    public partial class ProcesosIngreso
    {
        public int IdProcesoIngreso { get; set; }
        public string LogoUrlImagen { get; set; }
        public int? RequiereAutentificacion { get; set; }
        public int? ValIdarDatosUsuario { get; set; }
        public int? ValIdarDatosEmpresa { get; set; }
        public int? UsaAutentifiacionExterna { get; set; }
        public byte[] Banner { get; set; }
        public DateTime Creado { get; set; }
        public DateTime? Modificado { get; set; }
    }
}
