using System;
using System.Collections.Generic;

namespace Sitio.Models
{
    public partial class Propuestas
    {
        public int IdPropuestas { get; set; }
        public int IdUsuario { get; set; }
        public string NumeroMotor { get; set; }
        public string NumeroPatente { get; set; }
        public int? Ano { get; set; }
        public int? IdTipoVehiculo { get; set; }
        public int? IdMarca { get; set; }
        public int? IdModelo { get; set; }
        public int? Rut { get; set; }
        public string DigitoVerificador { get; set; }
        public string Nombre { get; set; }
        public string ApellIdoPaterno { get; set; }
        public string ApellIdoMaterno { get; set; }
        public string Telefono { get; set; }
        public string Mail { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public int? Estado { get; set; }
        public DateTime Creado { get; set; }
        public DateTime? Modificado { get; set; }
    }
}
