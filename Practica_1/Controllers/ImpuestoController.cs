using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Practica_1.Models;



namespace Practica_1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImpuestoController : ControllerBase
    {
        private readonly ImpuestoContext _context;
        public ImpuestoController(ImpuestoContext context)
        {
            _context = context;
            if (_context.Impuestos.Count() == 0)
            {
                // Crea un nuevo item si la coleccion esta vacia,
                // lo que significa que no puedes borrar todos los Items.
                _context.Impuestos.Add(new Impuesto { NumeroLiquidacion = 123, Grados = 30, ValorImpuesto = 6000 });
                _context.Impuestos.Add(new Impuesto { NumeroLiquidacion = 456, Grados = 40, ValorImpuesto = 16000 });
                _context.SaveChanges();
            }
        }     

        // GET: api/Task
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Impuesto>>> GetTaskItems()
        {
            return await _context.Impuestos.ToListAsync();
        }

        // GET: api/Task/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Impuesto>> GetTaskItem(int id)
        {
            var impuesto = await _context.Impuestos.FindAsync(id);
            if (impuesto == null)
            {
                return NotFound();
            }
            return impuesto;
        }

        // POST: api/Task
        [HttpPost]
        public async Task<ActionResult<Impuesto>> PostTaskItem(Impuesto item)
        {
            _context.Impuestos.Add(item);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetTaskItem), new { id = item.Id }, item);
        }
    }
}