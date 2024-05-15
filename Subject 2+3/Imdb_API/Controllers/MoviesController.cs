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
    public class MoviesController : ControllerBase
    {
        private readonly ImdbDbContext _context;

        public MoviesController(ImdbDbContext context)
        {
            _context = context;
        }

        // GET: api/Movies
        [HttpGet]
        public async Task<ActionResult<IEnumerable<title_basic>>> Gettitle_basics()
        {
            return await _context.title_basics.ToListAsync();
        }

        // GET: api/Movies/5
        [HttpGet("{id}")]
        public async Task<ActionResult<title_basic>> Gettitle_basic(string id)
        {
            var title_basic = await _context.title_basics.FindAsync(id);

            if (title_basic == null)
            {
                return NotFound();
            }

            return title_basic;
        }

        // PUT: api/Movies/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> Puttitle_basic(string id, title_basic title_basic)
        {
            if (id != title_basic.tconst)
            {
                return BadRequest();
            }

            _context.Entry(title_basic).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!title_basicExists(id))
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

        // POST: api/Movies
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<title_basic>> Posttitle_basic(title_basic title_basic)
        {
            _context.title_basics.Add(title_basic);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (title_basicExists(title_basic.tconst))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("Gettitle_basic", new { id = title_basic.tconst }, title_basic);
        }

        // DELETE: api/Movies/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Deletetitle_basic(string id)
        {
            var title_basic = await _context.title_basics.FindAsync(id);
            if (title_basic == null)
            {
                return NotFound();
            }

            _context.title_basics.Remove(title_basic);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool title_basicExists(string id)
        {
            return _context.title_basics.Any(e => e.tconst == id);
        }
    }
}
