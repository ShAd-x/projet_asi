using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
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
		public Bilan Bilan { get; set; }
		public Patient Patient { get; set; }

		public IActionResult OnGetAsync(int patientId)
		{
            Patient = _context.Patient.FirstOrDefault(p => p.Id == patientId);
            if (Patient == null)
            {
                return NotFound();
            }

			Bilan = new Bilan
			{
				PatientId = patientId,
				Patient = Patient,
				DateConsultation = DateTime.Now,
				HeureConsultation = DateTime.Now
            };

            return Page();
		}

		public async Task<IActionResult> OnPostAsync()
		{
			if (!ModelState.IsValid)
			{
				return Page();
			}

			_context.Bilan.Add(Bilan);
			await _context.SaveChangesAsync();

			return RedirectToPage("/GestionPatients/Details");
        }
	}
}
