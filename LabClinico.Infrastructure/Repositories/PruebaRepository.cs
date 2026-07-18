using LabClinico.Domain.Entities;
using LabClinico.Infrastructure.Context;
using LabClinico.Infrastructure.Core;
using LabClinico.Infrastructure.Interfaces;

namespace LabClinico.Infrastructure.Repositories
{
    public class PruebaRepository : BaseRepository<Prueba>, IPruebaRepository
    {
        public PruebaRepository(LabClinicoContext context) : base(context) { }
    }
}
