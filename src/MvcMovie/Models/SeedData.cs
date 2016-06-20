using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using System;
using System.Linq;

namespace MvcMovie.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ApplicationDbContext(
                serviceProvider.GetRequiredService<DbContextOptions<ApplicationDbContext>>()))
            {
                if (context.Movie.Any())
                {
                    return;   // DB has been seeded
                }

                context.Movie.AddRange(
                     new Movie
                     {
                         Title = "When Harry Met Sally",
                         Director = "Rob Reiner",
                         IMBD= 7.6F,
                         ReleaseDate = DateTime.Parse("1989-1-11"),
                         Genre = "Romantic Comedy",
                         Rating = "R",
                         Trailer= "https://www.youtube.com/watch?v=V8DgDmUHVto",
                         EmbededTrailer= "https://www.youtube.com/embed/V8DgDmUHVto",
                         MoviePoster = "http://ia.media-imdb.com/images/M/MV5BMjE0ODEwNjM2NF5BMl5BanBnXkFtZTcwMjU2Mzg3NA@@._V1_UY1200_CR85,0,630,1200_AL_.jpg",
                         Price = 7.99M
                     },

                     new Movie
                     {
                         Title = "Ghostbusters ",
                         Director = "Ivan Reitman",
                         IMBD= 7.8F,
                         ReleaseDate = DateTime.Parse("1984-3-13"),
                         Genre = "Comedy",
                         Rating = "PG",
                         Trailer = "https://www.youtube.com/watch?v=w3ugHP-yZXw",
                         EmbededTrailer = "https://www.youtube.com/embed/w3ugHP-yZXw",
                         MoviePoster = "http://cafmp.com/wp-content/uploads/2015/11/Ghostbusters.jpg",
                         Price = 8.99M
                     },

                     new Movie
                     {
                         Title = "Ghostbusters 2",
                         Director = "Ivan Reitman",
                         IMBD= 6.5F,
                         ReleaseDate = DateTime.Parse("1986-2-23"),
                         Genre = "Comedy",
                         Rating = "PG",
                         Trailer = "https://www.youtube.com/watch?v=UnzH75FlwvU",
                         EmbededTrailer = "https://www.youtube.com/embed/UnzH75FlwvU",
                         MoviePoster = "https://upload.wikimedia.org/wikipedia/en/0/01/Ghostbusters_ii_poster.jpg",
                         Price = 9.99M
                     },

                   new Movie
                   {
                       Title = "Rio Bravo",
                       Director = "Howard Hawks",
                       IMBD=8.1F,
                       ReleaseDate = DateTime.Parse("1959-4-15"),
                       Genre = "Western",
                       Rating = "R",
                       Trailer = "https://www.youtube.com/watch?v=WPO12ZzGS84",
                       EmbededTrailer = "https://www.youtube.com/embed/WPO12ZzGS84",
                       MoviePoster = "http://www.doctormacro.com/Images/Posters/R/Poster%20-%20Rio%20Bravo_01.jpg",
                       Price = 3.99M
                   }
                );
                context.SaveChanges();
            }
        }
    }
}