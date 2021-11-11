using System;
using System.Collections.Generic;

namespace Sitio.Models
{
    public partial class Propietarios
    {
        public int IdPropietario { get; set; }
        public int? Rut { get; set; }
        public string DigitoVerificador { get; set; }
        public string Nombre { get; set; }
        public string ApellIdoPaterno { get; set; }
        public string ApellIdoMaterno { get; set; }
        public DateTime? FechaNacimiento { get; set; }
        public int? Sexo { get; set; }
        public string Email { get; set; }
        public string Calle { get; set; }
        public int? Numero { get; set; }
        public int? Anexo { get; set; }
        public string Bloque { get; set; }
        public int? NumeroDepartamento { get; set; }
        public string Nota { get; set; }
        public string Telefono { get; set; }
        public DateTime Creado { get; set; }
        public DateTime? Modificado { get; set; }
    }
}
