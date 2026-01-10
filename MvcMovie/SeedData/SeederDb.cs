using Microsoft.EntityFrameworkCore;

using MvcMovie.Data;
using MvcMovie.Models;

namespace MvcMovie.SeedData;

public class SeederDb
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using var context = new MvcMovieContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<MvcMovieContext>>());

        // Look for any movies.
        if (context.Movie.Any())
        {
            return;   // DB has been seeded
        }
        context.Movie.AddRange(
            new Movie
            {
                Title = "When Harry Met Sally",
                ReleaseDate = DateTime.Parse("1989-2-12"),
                Genre = "Romantic Comedy",
                Price = 7.99M
            },
            new Movie
            {
                Title = "Ghostbusters ",
                ReleaseDate = DateTime.Parse("1984-3-13"),
                Genre = "Comedy",
                Price = 8.99M
            },
            new Movie
            {
                Title = "Ghostbusters 2",
                ReleaseDate = DateTime.Parse("1986-2-23"),
                Genre = "Comedy",
                Price = 9.99M
            },
            new Movie
            {
                Title = "Rio Bravo",
                ReleaseDate = DateTime.Parse("1959-4-15"),
                Genre = "Western",
                Price = 3.99M
            },
            new Movie
            {
                Title = "Inception",
                ReleaseDate = DateTime.Parse("2010-7-16"),
                Genre = "Science Fiction",
                Price = 10.99M
            },
            new Movie
            {
                Title = "The Dark Knight",
                ReleaseDate = DateTime.Parse("2008-7-18"),
                Genre = "Action",
                Price = 9.99M
            },
            new Movie
            {
                Title = "Interstellar",
                ReleaseDate = DateTime.Parse("2014-11-7"),
                Genre = "Science Fiction",
                Price = 12.99M
            },
            new Movie
            {
                Title = "The Matrix",
                ReleaseDate = DateTime.Parse("1999-3-31"),
                Genre = "Science Fiction",
                Price = 8.99M
            },
            new Movie
            {
                Title = "Pulp Fiction",
                ReleaseDate = DateTime.Parse("1994-10-14"),
                Genre = "Crime",
                Price = 7.99M
            },
            new Movie
            {
                Title = "The Shawshank Redemption",
                ReleaseDate = DateTime.Parse("1994-9-23"),
                Genre = "Drama",
                Price = 9.99M
            },
            new Movie
            {
                Title = "The Godfather",
                ReleaseDate = DateTime.Parse("1972-3-24"),
                Genre = "Crime",
                Price = 11.99M
            },
            new Movie
            {
                Title = "Forrest Gump",
                ReleaseDate = DateTime.Parse("1994-7-6"),
                Genre = "Drama",
                Price = 8.99M
            },
            new Movie
            {
                Title = "The Lion King",
                ReleaseDate = DateTime.Parse("1994-6-15"),
                Genre = "Animation",
                Price = 7.99M
            },
            new Movie
            {
                Title = "Titanic",
                ReleaseDate = DateTime.Parse("1997-12-19"),
                Genre = "Romance",
                Price = 9.99M
            },
            new Movie
            {
                Title = "Avatar",
                ReleaseDate = DateTime.Parse("2009-12-18"),
                Genre = "Science Fiction",
                Price = 10.99M
            },
            new Movie
            {
                Title = "Avengers: Endgame",
                ReleaseDate = DateTime.Parse("2019-4-26"),
                Genre = "Action",
                Price = 12.99M
            },
            new Movie
            {
                Title = "Joker",
                ReleaseDate = DateTime.Parse("2019-10-4"),
                Genre = "Crime",
                Price = 9.99M
            }
        );
        context.SaveChanges();
    }
}