using LabClinico.Domain.Entities;

namespace LabClinico.Infrastructure.Interfaces
{
    public interface IPruebaRepository
    {
        Task<IEnumerable<Prueba>> GetAllAsync();
        Task<Prueba?> GetByIdAsync(int id);
        Task AddAsync(Prueba prueba);
        Task UpdateAsync(Prueba prueba);
        Task DeleteAsync(int id);
    }
}
