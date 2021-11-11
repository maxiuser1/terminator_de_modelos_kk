using System;
using System.Collections.Generic;

namespace Sitio.Models
{
    public partial class EmisionPolizasPorSoporte
    {
        public int NumeroPoliza { get; set; }
        public string NombreBanco { get; set; }
        public int? NumeroTransaccion { get; set; }
        public byte[] ComprobantePago { get; set; }
        public string NombreArchivo { get; set; }
        public int? RutUsuarioLogueado { get; set; }
        public DateTime Creado { get; set; }
        public DateTime? Modificado { get; set; }
    }
}
