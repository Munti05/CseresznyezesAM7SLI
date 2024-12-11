using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class Collection
{
    public int CollectionId { get; set; }

    public int UserIdfk { get; set; }

    public int VinylIdfk { get; set; }

    public DateTime? Date { get; set; }

    public virtual User UserIdfkNavigation { get; set; } = null!;

    public virtual Vinyl VinylIdfkNavigation { get; set; } = null!;
}
