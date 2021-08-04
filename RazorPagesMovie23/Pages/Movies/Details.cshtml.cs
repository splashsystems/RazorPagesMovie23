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
    public class DetailsModel : PageModel
    {
        private readonly RazorPagesMovie23.Data.RazorPagesMovie23Context _context;

        public DetailsModel(RazorPagesMovie23.Data.RazorPagesMovie23Context context)
        {
            _context = context;
        }

        public Movie Movie { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Movie = await _context.Movie.FirstOrDefaultAsync(m => m.ID == id);

            if (Movie == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
