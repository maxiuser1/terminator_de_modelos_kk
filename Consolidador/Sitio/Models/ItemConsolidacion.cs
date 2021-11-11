using System;
using System.Collections.Generic;

namespace Sitio.Models
{
    public partial class ItemConsolidacion
    {
        public int Id { get; set; }
        public int? ConsolidacionId { get; set; }
        public int? IdModeloSeleccionado { get; set; }
        public string NombreModelo { get; set; }
        public int? IdMarca { get; set; }
        public string NombreMarca { get; set; }
        public int? IdTipoVehiculo { get; set; }
        public string NombreTipoVehiculo { get; set; }

        public virtual Consolidacion Consolidacion { get; set; }
    }
}
