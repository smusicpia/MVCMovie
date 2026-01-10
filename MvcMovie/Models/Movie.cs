using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlTypes;

using Microsoft.EntityFrameworkCore;

namespace MvcMovie.Models;

public class Movie
{
    public int Id { get; set; }
    public string? Title { get; set; }

    [DataType(DataType.Date)]
    public DateTime ReleaseDate { get; set; }

    public string? Genre { get; set; }

    public decimal Price { get; set; }
}