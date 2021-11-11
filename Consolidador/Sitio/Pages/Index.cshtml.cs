using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Sitio.Models;
using Sitio.ViewModels;

namespace Sitio.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public string CurrentFilter { get; set; }

        [BindProperty]
        public List<ItemModeloViewModel> Items { get; set; }

        [BindProperty]
        public string IdModeloConsolidable { get; set; }

        [BindProperty]
        public string NuevoIdMarca { get; set; }

        [BindProperty]
        public string NuevoIdTipoVehiculo { get; set; }

        [BindProperty]
        public string NuevoNombreModelo { get; set; }

        [BindProperty]
        public string NuevoNombreMarca { get; set; }

        [BindProperty]
        public string NuevoNombreTipoVehiculo { get; set; }

        private readonly SoapContext _db;
        public IndexModel(SoapContext db)
        {
            _db = db;
            this.Items = new List<ItemModeloViewModel>();
        }

        public void OnGet(string searchString)
        {
            this.CurrentFilter = searchString;
            if (!string.IsNullOrEmpty(searchString))
            {
                searchString = searchString.Replace("*", "%");
                var sql = $"SELECT modelos.IdModelo, \r\nmodelos.Nombre NombreModelo, \r\nmodelos.IdMarca, \r\nmarcas.Nombre NombreMarca, \r\nmodelos.IdTipoVehiculo,\r\ntiposvehiculos.Nombre NombreTipoVehiculo,\r\ncount(1) Cantidad \r\nFROM \r\nVehiculos \r\nJOIN Modelos ON Vehiculos.IdModelo = MODELOS.IdModelo \r\njoin marcas on modelos.IdMarca = marcas.IdMarca \r\nleft join TiposVehiculos on TiposVehiculos.IdTipoVehiculo = modelos.IdTipoVehiculo\r\nWHERE Modelos.Nombre like '{searchString}' \r\ngroup by modelos.IdModelo, modelos.Nombre , modelos.IdMarca, marcas.Nombre , modelos.IdTipoVehiculo, tiposvehiculos.Nombre \r\norder by modelos.Nombre";
                var items = _db.ItemsModelo.FromSqlRaw(sql).AsQueryable().ToList();

                foreach (var cadaItem in items)
                {
                    this.Items.Add(new ItemModeloViewModel
                    {
                        IdModelo = cadaItem.IdModelo,
                        NombreModelo = cadaItem.NombreModelo,
                        IdMarca = cadaItem.IdMarca,
                        NombreMarca = cadaItem.NombreMarca,
                        Cantidad = cadaItem.Cantidad,
                        IdTipoVehiculo = cadaItem.IdTipoVehiculo,
                        NombreTipoVehiculo = cadaItem.NombreTipoVehiculo
                    });
                }

            }
        }

        public IActionResult OnPost()
        {
            if (string.IsNullOrEmpty(this.IdModeloConsolidable))
                return RedirectToPage("/Index", new { searchString = this.CurrentFilter });


            var consolidacion = new Consolidacion
            {
                Fecha = DateTime.Now,
                IdModeloConsolidable = Convert.ToInt32(this.IdModeloConsolidable),
                NuevoNombreMarca = this.NuevoNombreMarca,
                NuevoNombreModelo = this.NuevoNombreModelo,
                NuevoNombreTipoVehiculo = this.NuevoNombreTipoVehiculo,
                IdNuevoMarca = int.TryParse(this.NuevoIdMarca, out int parserMarcaId) ? parserMarcaId : (int?)null,
                IdTipoVehiculo = int.TryParse(this.NuevoIdTipoVehiculo, out int parserTipo) ? parserTipo : (int?)null
            };

        

            foreach (var cada in Items.Where(t => t.Seleccionado))
            {
                if (cada.IdModelo != Convert.ToInt32(this.IdModeloConsolidable))
                {
                    consolidacion.ItemConsolidacion.Add(new ItemConsolidacion
                    {
                        IdModeloSeleccionado = cada.IdModelo
                    });

                    var vehiculos = _db.Vehiculos.Where(t => t.IdModelo == cada.IdModelo).ToList();
                    foreach (var cadaVehiculo in vehiculos)
                    {
                        cadaVehiculo.IdModelo = consolidacion.IdModeloConsolidable.Value;
                        if (consolidacion.IdNuevoMarca.HasValue)
                            cadaVehiculo.IdMarca = consolidacion.IdNuevoMarca.Value;
                        if (consolidacion.IdTipoVehiculo.HasValue)
                            cadaVehiculo.IdTipoVehiculo = consolidacion.IdTipoVehiculo.Value;
                    }
                }
            }

            var modelo = _db.Modelos.Find(Convert.ToInt32(this.IdModeloConsolidable));

            if (consolidacion.IdNuevoMarca.HasValue)
                modelo.IdMarca = consolidacion.IdNuevoMarca.Value;

            if (consolidacion.IdTipoVehiculo.HasValue)
                modelo.IdTipoVehiculo = consolidacion.IdTipoVehiculo.Value;

            if (!string.IsNullOrEmpty(this.NuevoNombreModelo))
                modelo.Nombre = this.NuevoNombreModelo;

            if (!string.IsNullOrEmpty(this.NuevoNombreMarca))
            {
                var marca = _db.Marcas.Find(Convert.ToInt32(modelo.IdMarca));
                marca.Nombre = this.NuevoNombreMarca;
            }

            if (!string.IsNullOrEmpty(this.NuevoNombreTipoVehiculo))
            {
                var tipoVehiculo = _db.TiposVehiculos.Find(Convert.ToInt32(modelo.IdTipoVehiculo));
                tipoVehiculo.Nombre = this.NuevoNombreTipoVehiculo;
            }

            _db.Consolidacion.Add(consolidacion);
            _db.SaveChanges();
            return RedirectToPage("/Index", new { searchString = this.CurrentFilter });
        }
    }
}
