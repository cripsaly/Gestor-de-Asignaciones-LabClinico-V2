using Microsoft.EntityFrameworkCore;
using LabClinicoAPI1.Models;

namespace LabClinicoAPI1.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<Prueba> Pruebas { get; set; }
    }
}