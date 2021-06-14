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
    public class LivrariController : ControllerBase
    {
        private readonly BioFreshContext _context;

        public LivrariController(BioFreshContext context)
        {
            _context = context;
        }

        // GET: api/Livrari
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Livrare>>> GetLivrare()
        {
            return await _context.Livrare.ToListAsync();
        }

        // GET: api/Livrari/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Livrare>> GetLivrare(Guid id)
        {
            var livrare = await _context.Livrare.FindAsync(id);

            if (livrare == null)
            {
                return NotFound();
            }

            return livrare;
        }

        // PUT: api/Livrari/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutLivrare(Guid id, Livrare livrare)
        {
            if (id != livrare.ID)
            {
                return BadRequest();
            }

            _context.Entry(livrare).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LivrareExists(id))
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

        // POST: api/Livrari
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Livrare>> PostLivrare(Livrare livrare)
        {
            _context.Livrare.Add(livrare);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetLivrare", new { id = livrare.ID }, livrare);
        }

        // DELETE: api/Livrari/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteLivrare(Guid id)
        {
            var livrare = await _context.Livrare.FindAsync(id);
            if (livrare == null)
            {
                return NotFound();
            }

            _context.Livrare.Remove(livrare);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool LivrareExists(Guid id)
        {
            return _context.Livrare.Any(e => e.ID == id);
        }
    }
}
