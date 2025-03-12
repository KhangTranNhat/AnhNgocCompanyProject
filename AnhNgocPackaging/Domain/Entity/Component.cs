using System;
using System.Collections.Generic;

namespace AnhNgocPackaging.Domain.Entity;

public partial class Component
{
    public int Id { get; set; }

    public string Type { get; set; } = null!;

    public string? Title { get; set; }

    public string? Description { get; set; }

    public string? Content { get; set; }

    public string? Config { get; set; }
}
