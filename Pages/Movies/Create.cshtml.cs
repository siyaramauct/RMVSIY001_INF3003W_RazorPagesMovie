using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RMVSIY001_INF3003W_RazorPagesMovie.Data;
using RMVSIY001_INF3003W_RazorPagesMovie.Models;

namespace RMVSIY001_INF3003W_RazorPagesMovie.Pages.Movies
{
    public class CreateModel : PageModel
    {
        private readonly RMVSIY001_INF3003W_RazorPagesMovie.Data.RMVSIY001_INF3003W_RazorPagesMovieContext _context;

        public CreateModel(RMVSIY001_INF3003W_RazorPagesMovie.Data.RMVSIY001_INF3003W_RazorPagesMovieContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Movie Movie { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Movie.Add(Movie);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
