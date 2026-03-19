using Microsoft.EntityFrameworkCore;
using RMVSIY001_INF3003W_RazorPagesMovie.Data;

namespace RMVSIY001_INF3003W_RazorPagesMovie.Models;

public static class SeedData
{
   public static void Initialize (IServiceProvider serviceProvider)
   {
       using (var context = new RMVSIY001_INF3003W_RazorPagesMovieContext(
           serviceProvider.GetRequiredService<
               DbContextOptions<RMVSIY001_INF3003W_RazorPagesMovieContext>>()))
       {
           if (context == null || context.Movie == null)
           {
               throw new ArgumentNullException("Null RMVSIY001_INF3003W_RazorPagesMovieContext");
            }
           
            if (context.Movie.Any())
           {
               return;  
           }
           context.Movie.AddRange(
               new Movie
               {
                   Title = "When Harry Met Sally",
                   ReleaseDate = DateTime.Parse("1989-2-12"),
                   Genre = "Romantic Comedy",
                   Price = 7.99M,
                   Rating = "R"
               },
               new Movie
               {
                   Title = "Ghostbusters ",
                   ReleaseDate = DateTime.Parse("1984-3-13"),
                   Genre = "Comedy",
                   Price = 8.99M,
                   Rating = "PG13"
               },
               new Movie
               {
                   Title = "Ghostbusters 2",
                   ReleaseDate = DateTime.Parse("1986-2-23"),
                   Genre = "Comedy",
                   Price = 9.99M,
                   Rating = "PG13"
               },
               new Movie
               {
                   Title = "Rio Bravo",
                   ReleaseDate = DateTime.Parse("1959-4-15"),
                   Genre = "Western",
                   Price = 3.99M,
                   Rating = "M"
               }
           );
           context.SaveChanges();
       }
    }
}