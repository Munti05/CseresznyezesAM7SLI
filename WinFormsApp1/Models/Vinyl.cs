using System;
using System.Collections.Generic;

namespace WinFormsApp1.Models;

public partial class Vinyl
{
    public int VinylId { get; set; }

    public string Title { get; set; } = null!;

    public string Artist { get; set; } = null!;

    public int? Year { get; set; }

    public string Genre { get; set; } = null!;

    public string? Description { get; set; }

    public decimal Value { get; set; }

    public virtual ICollection<Collection> Collections { get; set; } = new List<Collection>();
}
