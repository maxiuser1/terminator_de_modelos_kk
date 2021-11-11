using System;
using System.Collections.Generic;

namespace Sitio.Models
{
    public partial class Consolidacion
    {
        public Consolidacion()
        {
            ItemConsolidacion = new HashSet<ItemConsolidacion>();
        }

        public int Id { get; set; }
        public DateTime? Fecha { get; set; }
        public int? IdModeloConsolidable { get; set; }
        public string NuevoNombreMarca { get; set; }
        public string NuevoNombreModelo { get; set; }
        public int? IdNuevoMarca { get; set; }
        public int? IdTipoVehiculo { get; set; }
        public string NuevoNombreTipoVehiculo { get; set; }

        public virtual ICollection<ItemConsolidacion> ItemConsolidacion { get; set; }
    }
}
