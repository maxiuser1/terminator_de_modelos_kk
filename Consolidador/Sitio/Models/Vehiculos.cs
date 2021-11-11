using System;
using System.Collections.Generic;

namespace Sitio.Models
{
    public partial class Vehiculos
    {
        public int Idvehiculo { get; set; }
        public int IdTipoVehiculo { get; set; }
        public int IdModelo { get; set; }
        public int IdMarca { get; set; }
        public int IdPropietario { get; set; }
        public string NumeroPatente { get; set; }
        public string DigitoVerificadorPatente { get; set; }
        public int? Anio { get; set; }
        public string NumeroMotor { get; set; }
        public DateTime Creado { get; set; }
        public DateTime? Modificado { get; set; }
    }
}
