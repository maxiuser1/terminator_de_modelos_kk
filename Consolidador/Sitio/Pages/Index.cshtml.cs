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
        public string NuevoNombreModelo { get; set; }
        [BindProperty]
        public string NuevoNombreMarca { get; set; }

        private readonly soapContext _db;
        public IndexModel(soapContext db)
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
                var items = _db.ItemsModelo.FromSqlRaw($"SELECT \r\nmodelos.IdModelo, \r\nmodelos.Nombre NombreModelo, \r\nmodelos.IdMarca, \r\nmarcas.Nombre NombreMarca, \r\ncount(1) Cantidad\r\nFROM Vehiculos\r\nJOIN Modelos ON Vehiculos.IdModelo = MODELOS.IdModelo\r\njoin marcas on modelos.IdMarca = marcas.IdMarca\r\nWHERE Modelos.Nombre like '{searchString}'\r\ngroup by \r\nmodelos.IdModelo, \r\nmodelos.Nombre , \r\nmodelos.IdMarca, \r\nmarcas.Nombre order by modelos.Nombre").AsQueryable().ToList();

                foreach (var cadaItem in items)
                {
                    this.Items.Add(new ItemModeloViewModel
                    {
                        IdModelo = cadaItem.IdModelo,
                        NombreModelo = cadaItem.NombreModelo,
                        IdMarca = cadaItem.IdMarca,
                        NombreMarca = cadaItem.NombreMarca,
                        Cantidad = cadaItem.Cantidad,
                    });
                }

            }
        }

        public IActionResult OnPost()
        {
            int? nuevoIdMarca = null;
            if (Int32.TryParse(this.NuevoIdMarca, out int tempIdMarca))
            {
                nuevoIdMarca = tempIdMarca;
            }

            foreach (var cada in Items.Where(t => t.Seleccionado))
            {
                if (cada.IdModelo != Convert.ToInt32(this.IdModeloConsolidable))
                {
                    var vehiculos = _db.Vehiculos.Where(t => t.IdModelo == cada.IdModelo).ToList();
                    foreach (var cadaVehiculo in vehiculos)
                    {
                        cadaVehiculo.IdModelo = Convert.ToInt32(this.IdModeloConsolidable);
                        if (nuevoIdMarca.HasValue)
                            cadaVehiculo.IdMarca = nuevoIdMarca.Value;
                    }
                }

                var modelo = _db.Modelos.Find(Convert.ToInt32(this.IdModeloConsolidable));

                if (nuevoIdMarca.HasValue)
                    modelo.IdMarca = nuevoIdMarca.Value;

                if (!string.IsNullOrEmpty(this.NuevoNombreModelo))
                    modelo.Nombre = this.NuevoNombreModelo;

                if (!string.IsNullOrEmpty(this.NuevoNombreMarca))
                {
                    var marca = _db.Marcas.Find(Convert.ToInt32(modelo.IdMarca));
                    marca.Nombre = this.NuevoNombreMarca;
                }
            }
            _db.SaveChanges();
            return RedirectToPage("/Index", new { searchString = this.CurrentFilter });
        }
    }
}
