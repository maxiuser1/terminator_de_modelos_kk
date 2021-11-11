using System;
using System.Collections.Generic;

namespace Sitio.Models
{
    public partial class Empresas
    {
        public int IdEmpresa { get; set; }
        public int? IdModeloVenta { get; set; }
        public int? IdCanalVenta { get; set; }
        public int? Rut { get; set; }
        public string DigitoVerificador { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Calle { get; set; }
        public int? Numero { get; set; }
        public int? Anexo { get; set; }
        public string Bloque { get; set; }
        public int? NumeroDepartamento { get; set; }
        public string Nota { get; set; }
        public int? IdRegion { get; set; }
        public int? IdCiudad { get; set; }
        public int? IdComuna { get; set; }
        public DateTime Creado { get; set; }
        public DateTime? Modificado { get; set; }
    }
}
