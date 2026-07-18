using LabClinico.Application.Dtos.Paciente;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LabClinico.Application.Contract
{
    public interface IPacienteService
    {
        Task<IEnumerable<PacienteDto>> GetAllAsync();
        Task<PacienteDto> GetByIdAsync(int id);
        Task<PacienteDto> CreateAsync(PacienteDto pacienteDto);
        Task<bool> UpdateAsync(int id, PacienteDto pacienteDto);
        Task<bool> DeleteAsync(int id);
    }
}
