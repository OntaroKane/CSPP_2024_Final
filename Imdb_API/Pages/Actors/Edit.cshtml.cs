using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Imdb_API.Data;
using Imdb_API.Models.Entities;

namespace Imdb_API.Pages.Actors
{
    public class EditModel : PageModel
    {
        private readonly Imdb_API.Data.ImdbDbContext _context;

        public EditModel(Imdb_API.Data.ImdbDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public name_basic name_basics { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var name_basic =  await _context.name_basics.FirstOrDefaultAsync(m => m.nconst == id);
            if (name_basic == null)
            {
                return NotFound();
            }
            name_basic = name_basics;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(name_basics).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!name_basicExists(name_basics.nconst))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool name_basicExists(string id)
        {
            return _context.name_basics.Any(e => e.nconst == id);
        }
    }
}
