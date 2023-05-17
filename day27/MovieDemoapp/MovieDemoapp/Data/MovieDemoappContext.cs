using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MovieDemoapp.Models;

namespace MovieDemoapp.Data
{
    public class MovieDemoappContext : DbContext
    {
        public MovieDemoappContext (DbContextOptions<MovieDemoappContext> options)
            : base(options)
        {
        }

        public DbSet<MovieDemoapp.Models.Movie> Movie { get; set; } = default!;
    }
}
