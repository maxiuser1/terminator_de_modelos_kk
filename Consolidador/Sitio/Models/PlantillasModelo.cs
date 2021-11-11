using System;
using System.Collections.Generic;

namespace Sitio.Models
{
    public partial class PlantillasModelo
    {
        public int IdPlantillaModelo { get; set; }
        public string Nombre { get; set; }
        public DateTime Creado { get; set; }
        public DateTime? Modificado { get; set; }
    }
}
