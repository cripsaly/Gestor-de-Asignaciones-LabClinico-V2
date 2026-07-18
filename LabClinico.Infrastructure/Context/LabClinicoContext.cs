using Microsoft.EntityFrameworkCore;
using LabClinico.Domain.Entities;

namespace LabClinico.Infrastructure.Context
{
    public class LabClinicoContext : DbContext
    {
        public LabClinicoContext(DbContextOptions<LabClinicoContext> options) : base(options) { }

        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<Prueba> Pruebas { get; set; }
    }
}
