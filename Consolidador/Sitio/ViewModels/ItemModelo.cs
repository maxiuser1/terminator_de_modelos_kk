using System;
using System.Collections.Generic;
using System.IO.Pipelines;
using System.Linq;
using System.Threading.Tasks;

namespace Sitio.ViewModels
{
    public class ItemModelo
    {
        public int IdModelo { get; set; }
        public string NombreModelo { get; set; }
        public int IdMarca { get; set; }
        public string NombreMarca { get; set; }
        public int Cantidad { get; set; }

        public int? IdTipoVehiculo { get; set; }
        public string NombreTipoVehiculo { get; set; }
    }

    public class ItemModeloViewModel
    {
        public int IdModelo { get; set; }
        public string NombreModelo { get; set; }
        public int IdMarca { get; set; }
        public string NombreMarca { get; set; }
        public int Cantidad { get; set; }
        public bool Seleccionado { get; set; }
        public int? IdTipoVehiculo { get; set; }
        public string NombreTipoVehiculo { get; set; }
    }
}
