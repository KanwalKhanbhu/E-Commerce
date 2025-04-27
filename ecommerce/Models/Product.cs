﻿using System;
using System.Collections.Generic;

namespace ecommerce.Models;

public partial class Product
{
    public int ProductId { get; set; }

    public string? Name { get; set; }

    public decimal? Price { get; set; }

    public int? Stock { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
