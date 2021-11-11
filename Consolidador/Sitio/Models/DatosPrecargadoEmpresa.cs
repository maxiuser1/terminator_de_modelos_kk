using System;
using System.Collections.Generic;

namespace Sitio.Models
{
    public partial class DatosPrecargadoEmpresa
    {
        public int IdDatosPrecargadoEmpresa { get; set; }
        public int? IdEmpresa { get; set; }
        public int? Rut { get; set; }
        public string DigitoVerificador { get; set; }
        public int? NumeroTarjeta { get; set; }
        public int? Codigo { get; set; }
        public DateTime? Fecha { get; set; }
        public int? CodigoHomologacionVehiculo { get; set; }
        public string NumeroPatente { get; set; }
        public string Nombre { get; set; }
        public string ApellIdoPaterno { get; set; }
        public string ApellIdoMaterno { get; set; }
        public int? CodigoTipoVehiculo { get; set; }
        public string Password { get; set; }
        public string Pin { get; set; }
        public string Clave { get; set; }
        public string EstadoVoucher { get; set; }
        public int? Estado { get; set; }
        public int? IdPolizaSoap { get; set; }
        public DateTime Creado { get; set; }
        public DateTime? Modificado { get; set; }
    }
}
