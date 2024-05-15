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
    public class IndexModel : PageModel
    {
        private readonly Imdb_API.Data.ImdbDbContext _context;

        public IndexModel(Imdb_API.Data.ImdbDbContext context)
        {
            _context = context;
        }

        public IList<name_basic> name_basic { get;set; } = default!;

        public async Task OnGetAsync()
        {
            name_basic = await _context.name_basics.ToListAsync();
        }
    }
}
