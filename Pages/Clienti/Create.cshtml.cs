using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Proiect_Torok_Erika.Data;
using Proiect_Torok_Erika.Models;

namespace Proiect_Torok_Erika.Pages.Clienti
{
    public class CreateModel : PageModel
    {
        private readonly Proiect_Torok_Erika.Data.Proiect_Torok_ErikaContext _context;

        public CreateModel(Proiect_Torok_Erika.Data.Proiect_Torok_ErikaContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            ViewData["MaterialID"] = new SelectList(_context.Set<Material>(), "ID","NumeMaterial");

            return Page();
        }

        [BindProperty]
        public Client Client { get; set; }
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Client.Add(Client);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
