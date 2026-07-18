using LabClinico.Domain.Entities;
using LabClinico.Domain.Core; 
using Microsoft.AspNetCore.Mvc;

namespace LabClinicoAPI1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PruebasController : ControllerBase
    {
        private readonly IPruebaRepository _pruebaRepository;

      
        public PruebasController(IPruebaRepository pruebaRepository)
        {
            _pruebaRepository = pruebaRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Prueba>>> GetPruebas()
        {
            var pruebas = await _pruebaRepository.GetAllAsync();
            return Ok(pruebas);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Prueba>> GetPrueba(int id)
        {
            var prueba = await _pruebaRepository.GetByIdAsync(id);

            if (prueba == null)
            {
                return NotFound(new { mensaje = "La prueba de laboratorio no fue encontrada." });
            }

            return Ok(prueba);
        }
        [HttpPost]
        public async Task<ActionResult<Prueba>> PostPrueba(Prueba prueba)
        {
           
            await _pruebaRepository.AddAsync(prueba);
            await _pruebaRepository.SaveChangesAsync();

            return CreatedAtAction(nameof(GetPrueba), new { id = prueba.IdPrueba }, prueba);
        }
    }
}