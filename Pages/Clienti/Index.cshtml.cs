using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Proiect_Torok_Erika.Data;
using Proiect_Torok_Erika.Models;

namespace Proiect_Torok_Erika.Pages.Clienti
{
    public class IndexModel : PageModel
    {
        private readonly Proiect_Torok_Erika.Data.Proiect_Torok_ErikaContext _context;

        public IndexModel(Proiect_Torok_Erika.Data.Proiect_Torok_ErikaContext context)
        {
            _context = context;
        }

        public IList<Client> Client { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Client != null)
            {
                Client = await _context.Client
                    .Include(b=>b.Material) 
                    .ToListAsync();
            }
        }
    }
}
