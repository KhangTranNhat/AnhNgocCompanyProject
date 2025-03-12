using System;
using System.Collections.Generic;

namespace AnhNgocPackaging.Domain.Entity;

public partial class Banner
{
    public int Id { get; set; }

    public string ImageUrl { get; set; } = null!;

    public string? Url { get; set; }

    public int? Priority { get; set; }

    public string? Title { get; set; }

    public string? Description { get; set; }
}
