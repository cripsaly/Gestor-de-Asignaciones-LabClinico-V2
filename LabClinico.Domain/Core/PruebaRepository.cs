using LabClinico.Domain.Entities;
using LabClinico.Domain.Core;
using LabClinico.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace LabClinico.Infrastructure.core
{
    public class PruebaRepository : IPruebaRepository
    {
        private readonly LabClinicoContext _context;

        public PruebaRepository(LabClinicoContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Prueba>> GetAllAsync()
        {
            return await _context.Pruebas.ToListAsync();
        }

        public async Task<Prueba?> GetByIdAsync(int id)
        {
            return await _context.Pruebas.FindAsync(id);
        }

        public async Task AddAsync(Prueba prueba)
        {
            await _context.Pruebas.AddAsync(prueba);
        }

        public void Update(Prueba prueba)
        {
            _context.Pruebas.Update(prueba);
        }

        public void Delete(Prueba prueba)
        {
            _context.Pruebas.Remove(prueba);
        }

        public async Task<bool> SaveChangesAsync()
        {
            return (await _context.SaveChangesAsync()) > 0;
        }
    }
}