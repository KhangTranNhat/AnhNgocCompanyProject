using System;
using System.Collections.Generic;

namespace AnhNgocPackaging.Domain.Entity;

public partial class ProductCategory
{
    public uint Id { get; set; }

    public int? ParentId { get; set; }

    public string Name { get; set; } = null!;

    public string? ImageUrl { get; set; }

    public uint? Priority { get; set; }

    public string Slug { get; set; } = null!;

    public string? Description { get; set; }
}
