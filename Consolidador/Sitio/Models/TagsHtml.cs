using System;
using System.Collections.Generic;

namespace Sitio.Models
{
    public partial class TagsHtml
    {
        public int IdTagHtml { get; set; }
        public int? IdPlantillasModelo { get; set; }
        public string InnerHtml { get; set; }
        public string LabelHtml { get; set; }
        public string TipoDato { get; set; }
        public DateTime Creado { get; set; }
        public DateTime? Modificado { get; set; }
    }
}
