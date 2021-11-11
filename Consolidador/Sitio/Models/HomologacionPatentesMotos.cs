using System;
using System.Collections.Generic;

namespace Sitio.Models
{
    public partial class HomologacionPatentesMotos
    {
        public int Id { get; set; }
        public string Letra { get; set; }
        public int? Valor { get; set; }
        public DateTime Creado { get; set; }
        public string Modificado { get; set; }
    }
}
