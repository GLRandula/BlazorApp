using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BlazorApp1;

namespace BlazorApp1.Data
{
    public class BlazorApp1Context : DbContext
    {
        public BlazorApp1Context (DbContextOptions<BlazorApp1Context> options)
            : base(options)
        {
        }

        public DbSet<BlazorApp1.Movie> Movie { get; set; } = default!;
    }
}
