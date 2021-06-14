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
    public class ComenziController : ControllerBase
    {
        private readonly BioFreshContext _context;

        public ComenziController(BioFreshContext context)
        {
            _context = context;
        }

        // GET: api/Comenzi
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Comanda>>> GetComanda()
        {
            return await _context.Comanda.ToListAsync();
        }

        // GET: api/Comenzi/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Comanda>> GetComanda(Guid id)
        {
            var comanda = await _context.Comanda.FindAsync(id);

            if (comanda == null)
            {
                return NotFound();
            }

            return comanda;
        }

        // PUT: api/Comenzi/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutComanda(Guid id, Comanda comanda)
        {
            if (id != comanda.ID)
            {
                return BadRequest();
            }

            _context.Entry(comanda).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ComandaExists(id))
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

        // POST: api/Comenzi
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Comanda>> PostComanda(Comanda comanda)
        {
            _context.Comanda.Add(comanda);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetComanda", new { id = comanda.ID }, comanda);
        }

        // DELETE: api/Comenzi/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteComanda(Guid id)
        {
            var comanda = await _context.Comanda.FindAsync(id);
            if (comanda == null)
            {
                return NotFound();
            }

            _context.Comanda.Remove(comanda);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ComandaExists(Guid id)
        {
            return _context.Comanda.Any(e => e.ID == id);
        }
    }
}
