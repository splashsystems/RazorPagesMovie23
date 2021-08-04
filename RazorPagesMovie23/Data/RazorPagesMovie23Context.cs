using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovie23.Models;

namespace RazorPagesMovie23.Data
{
    public class RazorPagesMovie23Context : DbContext
    {
        public RazorPagesMovie23Context (DbContextOptions<RazorPagesMovie23Context> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesMovie23.Models.Movie> Movie { get; set; }
    }
}
