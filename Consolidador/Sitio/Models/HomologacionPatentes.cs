using System;
using System.Collections.Generic;

namespace Sitio.Models
{
    public partial class HomologacionPatentes
    {
        public int IdHomologacionPatente { get; set; }
        public int? IdUsuario { get; set; }
        public DateTime? FechaIngreso { get; set; }
        public string LetrasPatente { get; set; }
        public string UrlEvIdencia { get; set; }
        public DateTime Creado { get; set; }
        public DateTime? Modificado { get; set; }
    }
}
