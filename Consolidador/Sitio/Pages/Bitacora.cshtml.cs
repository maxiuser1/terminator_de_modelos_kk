using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Sitio.Models;

namespace Sitio.Pages
{
    public class BitacoraModel : PageModel
    {
        private readonly SoapContext _db;

        public List<Consolidacion> Consolidaciones { get; set; }
        public BitacoraModel(SoapContext db)
        {
            _db = db;
        }

        public void OnGet()
        {
            this.Consolidaciones = _db.Consolidacion.Include(t => t.ItemConsolidacion).OrderByDescending(t => t.Fecha).ToList();
        }
    }
}
