using System;
using System.Collections.Generic;

namespace Sitio.Models
{
    public partial class Configuracionmodeloventas
    {
        public int Idconfiguracionmodeloventa { get; set; }
        public int? Idprocesorecaudacionmanual { get; set; }
        public int? Idprocesoventaonline { get; set; }
        public int? Idcanalventa { get; set; }
        public int? Idempresa { get; set; }
        public int? Idmodeloventa { get; set; }
        public int? Idprocesoventamasiva { get; set; }
        public int? Idprocesorecaudaciononline { get; set; }
        public int? Idprocesoingreso { get; set; }
        public int? Idprocesoemision { get; set; }
        public int? Idplantillamodelo { get; set; }
        public string Urlbannerempresa { get; set; }
        public bool? Estado { get; set; }
        public bool? Tipopago { get; set; }
        public bool? Habilitaasignacionusuario { get; set; }
        public string Urlretorno { get; set; }
        public DateTime Creado { get; set; }
        public DateTime? Modificado { get; set; }
        public bool Habilitaediciontipovehiculo { get; set; }
    }
}
