using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class User
{
    public int UserId { get; set; }

    public string Username { get; set; } = null!;

    public string Email { get; set; } = null!;

    public virtual ICollection<Collection> Collections { get; set; } = new List<Collection>();
}
