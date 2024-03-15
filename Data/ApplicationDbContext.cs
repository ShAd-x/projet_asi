using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Projet_ASI.Models;

namespace Projet_ASI.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Patient>? Patient { get; set; } 
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
