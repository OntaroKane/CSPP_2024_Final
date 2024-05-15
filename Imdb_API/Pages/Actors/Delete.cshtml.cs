using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Imdb_API.Data;
using Imdb_API.Models.Entities;

namespace Imdb_API.Pages.Actors
{
    public class DeleteModel : PageModel
    {
        private readonly Imdb_API.Data.ImdbDbContext _context;

        public DeleteModel(Imdb_API.Data.ImdbDbContext context)
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

            var name_basic = await _context.name_basics.FirstOrDefaultAsync(m => m.nconst == id);

            if (name_basic == null)
            {
                return NotFound();
            }
            else
            {
                name_basic = name_basics;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var name_basic = await _context.name_basics.FindAsync(id);
            if (name_basic != null)
            {
                name_basic = name_basics;
                _context.name_basics.Remove(name_basic);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
