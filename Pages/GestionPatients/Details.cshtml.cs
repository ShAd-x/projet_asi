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

namespace Projet_ASI.Pages.GestionPatients
{
    [Authorize(Roles = "Administrateur,Medecin")]
    public class DetailsModel : PageModel
    {
        private readonly Projet_ASI.Data.ApplicationDbContext _context;

        public DetailsModel(Projet_ASI.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public Patient Patient { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var patient = await _context.Patient
                .Include(p => p.Bilan)
                .FirstOrDefaultAsync(m => m.Id == id);

            if (patient == null)
            {
                return NotFound();
            }
            else
            {
                patient.Medecin = await _context.Medecin.FirstOrDefaultAsync(m => m.Id == patient.MedecinId);
                Patient = patient;
            }
            return Page();
        }
    }
}
