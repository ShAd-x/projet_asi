using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Projet_ASI.Data;
using Projet_ASI.Models;

namespace Projet_ASI.Pages.Medecins
{
    [Authorize(Roles = "Administrateur,Medecin")]
    public class DetailsModel : PageModel
    {
        private readonly Projet_ASI.Data.ApplicationDbContext _context;

        public DetailsModel(Projet_ASI.Data.ApplicationDbContext context)
        {
            _context = context;
        }

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
    }
}
