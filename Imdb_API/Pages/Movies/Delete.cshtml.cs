using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Imdb_API.Data;
using Imdb_API.Models.Entities;

namespace Imdb_API.Pages.Movies
{
    public class DeleteModel : PageModel
    {
        private readonly Imdb_API.Data.ImdbDbContext _context;

        public DeleteModel(Imdb_API.Data.ImdbDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public title_basic title_basics { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var title_basic = await _context.title_basics.FirstOrDefaultAsync(m => m.tconst == id);

            if (title_basic == null)
            {
                return NotFound();
            }
            else
            {
                title_basic = title_basics;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var title_basic = await _context.title_basics.FindAsync(id);
            if (title_basic != null)
            {
                title_basic = title_basics;
                _context.title_basics.Remove(title_basic);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
