using System;
using System.Collections.Generic;

namespace Sitio.Models
{
    public partial class Usuarios
    {
        public int IdUsuario { get; set; }
        public int IdSucursal { get; set; }
        public int IdPerfiles { get; set; }
        public int? Rut { get; set; }
        public string DigitoVerificador { get; set; }
        public string Nombre { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public DateTime? FechaNacimiento { get; set; }
        public int? Sexo { get; set; }
        public string Email { get; set; }
        public string Contrasenia { get; set; }
        public string Calle { get; set; }
        public int? Numero { get; set; }
        public int? Anexo { get; set; }
        public string Bloque { get; set; }
        public int? NumeroDepartamento { get; set; }
        public string Nota { get; set; }
        public string Login { get; set; }
        public string Telefono { get; set; }
        public DateTime Creado { get; set; }
        public DateTime? Modificado { get; set; }
    }
}
