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
    public class IndexModel : PageModel
    {
        private readonly Projet_ASI.Data.ApplicationDbContext _context;

        public IndexModel(Projet_ASI.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Medecin> Medecin { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Medecin = await _context.Medecin.ToListAsync();
        }
    }
}
