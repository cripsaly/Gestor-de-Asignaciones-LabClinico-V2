using LabClinico.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LabClinico.Domain
{
    public class PruebaRepository
    {
        private readonly List<Prueba> _pruebasTemp = new List<Prueba>();

        public async Task<IEnumerable<Prueba>> GetAllAsync()
        {
            return _pruebasTemp;
        }

        public async Task<Prueba> GetByIdAsync(int id)
        {
            return _pruebasTemp.Find(p => p.Id == id);
        }

        public async Task CreateAsync(Prueba prueba)
        {
            _pruebasTemp.Add(prueba);
        }
    }
}