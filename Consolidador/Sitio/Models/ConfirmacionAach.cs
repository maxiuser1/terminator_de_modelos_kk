using System;
using System.Collections.Generic;

namespace Sitio.Models
{
    public partial class ConfirmacionAach
    {
        public int IdConfirmacionAach { get; set; }
        public string NumeroFolio { get; set; }
        public int? TipoPoliza { get; set; }
        public int? NumeroPoliza { get; set; }
        public string RutCompania { get; set; }
        public string Patente { get; set; }
        public string DigitoVerificadorPatente { get; set; }
        public string TipoVehiculo { get; set; }
        public string MarcaVehiculo { get; set; }
        public string ModeloVehiculo { get; set; }
        public int? AnoVehiculo { get; set; }
        public string NumeroMotor { get; set; }
        public string RutPropietario { get; set; }
        public string NombrePropietario { get; set; }
        public DateTime? FechaTermino { get; set; }
        public DateTime? FechaInicio { get; set; }
        public int? Prima { get; set; }
        public string Usuario { get; set; }
        public string Clave { get; set; }
        public int? Confirmado { get; set; }
        public string CodigoError { get; set; }
        public string MensajeError { get; set; }
        public DateTime? FechaAnulacion { get; set; }
        public int? IdUsuario { get; set; }
        public string Ticket { get; set; }
        public DateTime Creado { get; set; }
        public DateTime? Modificado { get; set; }
    }
}
