using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Imdb_API.Data;
using Imdb_API.Models.Entities;

namespace Imdb_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActorsController : ControllerBase
    {
        private readonly ImdbDbContext _context;

        public ActorsController(ImdbDbContext context)
        {
            _context = context;
        }

        // GET: api/Actors
        [HttpGet]
        public async Task<ActionResult<IEnumerable<name_basic>>> Getname_basics()
        {
            return await _context.name_basics.ToListAsync();
        }

        // GET: api/Actors/5
        [HttpGet("{id}")]
        public async Task<ActionResult<name_basic>> Getname_basic(string id)
        {
            var name_basic = await _context.name_basics.FindAsync(id);

            if (name_basic == null)
            {
                return NotFound();
            }

            return name_basic;
        }

        // PUT: api/Actors/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> Putname_basic(string id, name_basic name_basic)
        {
            if (id != name_basic.nconst)
            {
                return BadRequest();
            }

            _context.Entry(name_basic).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!name_basicExists(id))
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

        // POST: api/Actors
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<name_basic>> Postname_basic(name_basic name_basic)
        {
            _context.name_basics.Add(name_basic);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (name_basicExists(name_basic.nconst))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("Getname_basic", new { id = name_basic.nconst }, name_basic);
        }

        // DELETE: api/Actors/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Deletename_basic(string id)
        {
            var name_basic = await _context.name_basics.FindAsync(id);
            if (name_basic == null)
            {
                return NotFound();
            }

            _context.name_basics.Remove(name_basic);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool name_basicExists(string id)
        {
            return _context.name_basics.Any(e => e.nconst == id);
        }
    }
}
