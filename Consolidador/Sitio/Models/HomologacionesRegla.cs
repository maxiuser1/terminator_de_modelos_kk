using System;
using System.Collections.Generic;

namespace Sitio.Models
{
    public partial class HomologacionesRegla
    {
        public int IdHomologacionRegla { get; set; }
        public int? Codigo { get; set; }
        public string Descripcion { get; set; }
        public int? IdRegla { get; set; }
        public int? RequiereValor { get; set; }
        public DateTime Creado { get; set; }
        public DateTime? Modificado { get; set; }
    }
}
