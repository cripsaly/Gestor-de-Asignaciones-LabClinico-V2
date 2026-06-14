using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using LabClinicoAPI1.Data;
using LabClinicoAPI1.Models;

namespace LabClinicoAPI1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PruebasController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public PruebasController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Prueba>>> GetPruebas()
        {
            return await _context.Pruebas.ToListAsync(); 
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Prueba>> GetPrueba(int id)
        {
            var prueba = await _context.Pruebas.FindAsync(id);

            if (prueba == null)
            {
                return NotFound();
            }

            return prueba;
        }

        [HttpPost]
        public async Task<ActionResult<Prueba>> PostPrueba(Prueba prueba)
        {
            _context.Pruebas.Add(prueba);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetPrueba), new { id = prueba.Id }, prueba);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutPrueba(int id, Prueba prueba)
        {
            if (id != prueba.Id)
            {
                return BadRequest();
            }

            _context.Entry(prueba).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_context.Pruebas.Any(e => e.Id == id))
                {
                    return NotFound();
                }
                throw;
            }

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePrueba(int id)
        {
            var prueba = await _context.Pruebas.FindAsync(id);
            if (prueba == null)
            {
                return NotFound();
            }

            _context.Pruebas.Remove(prueba);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}