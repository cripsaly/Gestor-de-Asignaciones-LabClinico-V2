using LabClinico.Domain.Entities;

namespace LabClinico.Domain.Core
{
    public interface IPruebaRepository
    {
        Task<IEnumerable<Prueba>> GetAllAsync();
        Task<Prueba?> GetByIdAsync(int id);
        Task AddAsync(Prueba prueba);
        void Update(Prueba prueba);
        void Delete(Prueba prueba);
        Task<bool> SaveChangesAsync();
    }
}