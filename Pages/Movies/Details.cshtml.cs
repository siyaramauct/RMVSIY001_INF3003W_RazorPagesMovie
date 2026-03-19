using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RMVSIY001_INF3003W_RazorPagesMovie.Data;
using RMVSIY001_INF3003W_RazorPagesMovie.Models;

namespace RMVSIY001_INF3003W_RazorPagesMovie.Pages.Movies
{
    public class DetailsModel : PageModel
    {
        private readonly RMVSIY001_INF3003W_RazorPagesMovie.Data.RMVSIY001_INF3003W_RazorPagesMovieContext _context;

        public DetailsModel(RMVSIY001_INF3003W_RazorPagesMovie.Data.RMVSIY001_INF3003W_RazorPagesMovieContext context)
        {
            _context = context;
        }

        public Movie Movie { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var movie = await _context.Movie.FirstOrDefaultAsync(m => m.Id == id);

            if (movie is not null)
            {
                Movie = movie;

                return Page();
            }

            return NotFound();
        }
    }
}
