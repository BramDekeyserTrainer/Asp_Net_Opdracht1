using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Asp_Net_Opdracht1.Models;

namespace Asp_Net_Opdracht1.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Asp_Net_Opdracht1.Models.Speler> Speler { get; set; }
        public DbSet<Asp_Net_Opdracht1.Models.Club> Club { get; set; }
        public DbSet<Asp_Net_Opdracht1.Models.Niveau> Niveau { get; set; }
    }
}