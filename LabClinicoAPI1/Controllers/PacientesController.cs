using Microsoft.AspNetCore.Mvc;
using LabClinico.Domain.Entities;
using LabClinico.Infrastructure.Interfaces;

namespace LabClinicoAPI1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PacientesController : ControllerBase
    {
        private readonly IPacienteRepository _repository;

        public PacientesController(IPacienteRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var pacientes = await _repository.GetAllAsync();
            return Ok(pacientes);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var paciente = await _repository.GetByIdAsync(id);
            if (paciente == null) return NotFound("Paciente no encontrado");
            return Ok(paciente);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] Paciente paciente)
        {
            await _repository.AddAsync(paciente);
            return CreatedAtAction(nameof(GetById), new { id = paciente.Id }, paciente);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] Paciente paciente)
        {
            if (id != paciente.Id) return BadRequest("El ID no coincide");
            await _repository.UpdateAsync(paciente);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _repository.DeleteAsync(id);
            return NoContent();
        }
    }
}