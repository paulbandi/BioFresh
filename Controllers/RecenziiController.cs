using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BioFresh.Data;
using BioFresh.Models;

namespace BioFresh.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecenziiController : ControllerBase
    {
        private readonly BioFreshContext _context;

        public RecenziiController(BioFreshContext context)
        {
            _context = context;
        }

        // GET: api/Recenzii
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Recenzie>>> GetStatus()
        {
            return await _context.Recenzie.ToListAsync();
        }

        // GET: api/Recenzii/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Recenzie>> GetRecenzie(Guid id)
        {
            var recenzie = await _context.Recenzie.FindAsync(id);

            if (recenzie == null)
            {
                return NotFound();
            }

            return recenzie;
        }

        // PUT: api/Recenzii/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRecenzie(Guid id, Recenzie recenzie)
        {
            if (id != recenzie.ID)
            {
                return BadRequest();
            }

            _context.Entry(recenzie).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RecenzieExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Recenzii
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Recenzie>> PostRecenzie(Recenzie recenzie)
        {
            _context.Recenzie.Add(recenzie);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetRecenzie", new { id = recenzie.ID }, recenzie);
        }

        // DELETE: api/Recenzii/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRecenzie(Guid id)
        {
            var recenzie = await _context.Recenzie.FindAsync(id);
            if (recenzie == null)
            {
                return NotFound();
            }

            _context.Recenzie.Remove(recenzie);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool RecenzieExists(Guid id)
        {
            return _context.Recenzie.Any(e => e.ID == id);
        }
    }
}
