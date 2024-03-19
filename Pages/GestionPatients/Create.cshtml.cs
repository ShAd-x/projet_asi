using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Projet_ASI.Data;
using Projet_ASI.Models;

namespace Projet_ASI.Pages.GestionPatients
{
    [Authorize(Roles = "Administrateur,Medecin")]
    public class CreateModel : PageModel
    {
        private readonly Projet_ASI.Data.ApplicationDbContext _context;

        public CreateModel(Projet_ASI.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            ViewData["MedecinId"] = new SelectList(_context.Medecin, "Id", "Nom");
            return Page();
        }

        [BindProperty]
        public Patient Patient { get; set; } = default!;

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Patient.Add(Patient);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
