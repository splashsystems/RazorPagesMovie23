using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovie23.Data;
using RazorPagesMovie23.Models;

namespace RazorPagesMovie23.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly RazorPagesMovie23.Data.RazorPagesMovie23Context _context;

        public IndexModel(RazorPagesMovie23.Data.RazorPagesMovie23Context context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; }

        public async Task OnGetAsync()
        {
            Movie = await _context.Movie.ToListAsync();
        }
    }
}
