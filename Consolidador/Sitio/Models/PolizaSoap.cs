using System;
using System.Collections.Generic;

namespace Sitio.Models
{
    public partial class PolizaSoap
    {
        public int IdPolizaSoap { get; set; }
        public DateTime? FechaEmision { get; set; }
        public string AbreviacionElectronica { get; set; }
        public decimal? NumeroPoliza { get; set; }
        public decimal? NumeroFolio { get; set; }
        public DateTime? VigenciaDesde { get; set; }
        public DateTime? VigenciaHasta { get; set; }
        public string UrlPolizaSoap { get; set; }
        public byte[] Pdf { get; set; }
        public DateTime Creado { get; set; }
        public DateTime? Modificado { get; set; }
    }
}
