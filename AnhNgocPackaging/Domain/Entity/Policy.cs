using System;
using System.Collections.Generic;

namespace AnhNgocPackaging.Domain.Entity;

public partial class Policy
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public string? Description { get; set; }

    public string ImageUrl { get; set; } = null!;

    public int? Priority { get; set; }
}
