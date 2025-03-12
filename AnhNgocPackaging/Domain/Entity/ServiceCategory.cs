using System;
using System.Collections.Generic;

namespace AnhNgocPackaging.Domain.Entity;

public partial class ServiceCategory
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public string? ImageUrl { get; set; }
}
