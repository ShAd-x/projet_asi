using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Identity.Client;
using Projet_ASI.Data;
using Projet_ASI.Models;

namespace Projet_ASI.Pages.Bilans
{
    public class CreateModel : PageModel
    {
        private readonly Projet_ASI.Data.ApplicationDbContext _context;

        public CreateModel(Projet_ASI.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        Patient Patient { get; set; } = default!;
        [BindProperty]
        public Bilan Bilan { get; set; } = default!;


        public async Task<IActionResult> OnGetAsync(int? patientId)
        {
            if (patientId == null)
            {
                return NotFound();
            }

            Patient = _context.Patient.Find(patientId);

            
            if (Patient == null)
            {
                return NotFound();
            }

            Bilan = new Bilan
            {
                PatientId = patientId,
                Patient = Patient  
            };

           
            return Page();
        }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Bilan.Add(Bilan);
            await _context.SaveChangesAsync();

            return RedirectToPage("../GestionPatients/Index");
        }
    }
}
