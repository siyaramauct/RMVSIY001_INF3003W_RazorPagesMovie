using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RMVSIY001_INF3003W_RazorPagesMovie.Models;

namespace RMVSIY001_INF3003W_RazorPagesMovie.Data
{
    public class RMVSIY001_INF3003W_RazorPagesMovieContext : DbContext
    {
        public RMVSIY001_INF3003W_RazorPagesMovieContext (DbContextOptions<RMVSIY001_INF3003W_RazorPagesMovieContext> options)
            : base(options)
        {
        }

        public DbSet<RMVSIY001_INF3003W_RazorPagesMovie.Models.Movie> Movie { get; set; } = default!;
    }
}
