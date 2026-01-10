using Microsoft.AspNetCore.Mvc.Rendering;

namespace MvcMovie.Models;

public class MovieGenreViewModel
{
    public SelectList? Genres { get; set; }
    public List<Movie>? Movies { get; set; }
    public string? MovieGenre { get; set; }
    public string? SearchString { get; set; }
}