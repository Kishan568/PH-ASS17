using System;
using System.Collections.Generic;

namespace WebAPIAssignment17.Models;

public partial class Movie
{
    public int Id { get; set; }

    public string? Title { get; set; }

    public string? Director { get; set; }

    public DateTime? ReleaseDate { get; set; }

    public string? Genre { get; set; }

    public double? Rating { get; set; }
}
