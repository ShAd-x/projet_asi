using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Projet_ASI.Data;
using Projet_ASI.Models;

namespace Projet_ASI.Pages.Medecins
{
    public class DeleteModel : PageModel
    {
        private readonly Projet_ASI.Data.ApplicationDbContext _context;

        public DeleteModel(Projet_ASI.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Medecin Medecin { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var medecin = await _context.Medecin.FirstOrDefaultAsync(m => m.Id == id);

            if (medecin == null)
            {
                return NotFound();
            }
            else
            {
                Medecin = medecin;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var medecin = await _context.Medecin.FindAsync(id);
            if (medecin != null)
            {
                Medecin = medecin;
                _context.Medecin.Remove(Medecin);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
