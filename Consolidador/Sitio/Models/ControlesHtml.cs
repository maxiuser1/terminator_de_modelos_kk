using System;
using System.Collections.Generic;

namespace Sitio.Models
{
    public partial class ControlesHtml
    {
        public int IdControl { get; set; }
        public int IdProcesoIngreso { get; set; }
        public string TagHtml { get; set; }
        public bool? Activo { get; set; }
        public string LabelHtml { get; set; }
        public int? IdTagHtml { get; set; }
        public DateTime Creado { get; set; }
        public DateTime? Modificado { get; set; }
    }
}
