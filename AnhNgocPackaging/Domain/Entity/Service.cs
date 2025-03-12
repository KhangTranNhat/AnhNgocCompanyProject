using System;
using System.Collections.Generic;

namespace AnhNgocPackaging.Domain.Entity;

public partial class Service
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string ImageUrl { get; set; } = null!;

    public string? Description { get; set; }

    public string? Content { get; set; }
}
