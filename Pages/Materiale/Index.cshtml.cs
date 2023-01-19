using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Proiect_Torok_Erika.Data;
using Proiect_Torok_Erika.Models;
using Proiect_Torok_Erika.Models.ViewModels;

namespace Proiect_Torok_Erika.Pages.Materiale
{
    public class IndexModel : PageModel
    {
        private readonly Proiect_Torok_Erika.Data.Proiect_Torok_ErikaContext _context;

        public IndexModel(Proiect_Torok_Erika.Data.Proiect_Torok_ErikaContext context)
        {
            _context = context;
        }

        public IList<Material> Material { get;set; } = default!;
        public MaterialIndexData MaterialData { get; set; }
        public int MaterialID { get; set; }
        public int ClientID { get; set; }
        public async Task OnGetAsync(int? id, int? bookID)
        {
            MaterialData = new MaterialIndexData();
            MaterialData.Materiale = await _context.Material
            .Include(i => i.Clienti)
            .ThenInclude(c => c.Produs)
            .OrderBy(i => i.NumeMaterial)
            .ToListAsync();
            if (id != null)
            {
                MaterialID = id.Value;
                Material publisher = MaterialData.Materiale
                .Where(i => i.ID == id.Value).Single();
                MaterialData.Clienti = publisher.Clienti;
            }
            }
        }
    }
