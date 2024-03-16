using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Projet_ASI.Data;
using Projet_ASI.Models;

namespace Projet_ASI.Pages.Medecins
{
    public class CreateModel : PageModel
    {
        private readonly Projet_ASI.Data.ApplicationDbContext _context;

        public CreateModel(Projet_ASI.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Medecin Medecin { get; set; } = default!;

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Medecin.Add(Medecin);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
