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
    public class MeniuriController : ControllerBase
    {
        private readonly BioFreshContext _context;

        public MeniuriController(BioFreshContext context)
        {
            _context = context;
        }

        // GET: api/Meniuri
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Meniu>>> GetMeniu()
        {
            return await _context.Meniu.ToListAsync();
        }

        // GET: api/Meniuri/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Meniu>> GetMeniu(Guid id)
        {
            var meniu = await _context.Meniu.FindAsync(id);

            if (meniu == null)
            {
                return NotFound();
            }

            return meniu;
        }

        // PUT: api/Meniuri/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMeniu(Guid id, Meniu meniu)
        {
            if (id != meniu.ID)
            {
                return BadRequest();
            }

            _context.Entry(meniu).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MeniuExists(id))
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

        // POST: api/Meniuri
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Meniu>> PostMeniuri(Meniu meniu)
        {
            _context.Meniu.Add(meniu);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMeniu", new { id = meniu.ID }, meniu);
        }

        // DELETE: api/Meniuri/5
        [HttpDelete("{id}")]
        public async Task DeleteMeniu(Guid id)
        {
            Meniu meniu = await _context.Meniu.FindAsync(id);
            if (meniu != null)
            {
                _context.Meniu.Remove(meniu);
                await _context.SaveChangesAsync();
            }

        }

        private bool MeniuExists(Guid id)
        {
            return _context.Meniu.Any(e => e.ID == id);
        }
    }
}
