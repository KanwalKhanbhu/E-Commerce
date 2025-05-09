﻿using System;
using System.Collections.Generic;

namespace ecommerce.Models;

public partial class Order
{
    public int OrderId { get; set; }

    public int? CustomerId { get; set; }

    public int? ProductId { get; set; }

    public int? Quantity { get; set; }

    public DateOnly? OrderDate { get; set; }

    public virtual Customer? Customer { get; set; }

    public virtual Product? Product { get; set; }
}
