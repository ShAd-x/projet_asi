using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Projet_ASI.Data;
using Projet_ASI.Models;

namespace Projet_ASI.Pages.GestionPatients
{
    public class IndexModel : PageModel
    {
        private readonly Projet_ASI.Data.ApplicationDbContext _context;

        public IndexModel(Projet_ASI.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Patient> Patient { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Patient = await _context.Patient.Include(p => p.Medecin).ToListAsync();
        }
    }
}
