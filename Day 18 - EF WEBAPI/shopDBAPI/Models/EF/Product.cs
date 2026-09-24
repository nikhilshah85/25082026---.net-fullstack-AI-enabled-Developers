using System;
using System.Collections.Generic;

namespace shopDBAPI.Models.EF;

public partial class Product
{
    public int PId { get; set; }

    public string? PName { get; set; }

    public string? PCategory { get; set; }

    public decimal? PPrice { get; set; }

    public int? PQty { get; set; }

    public bool? PIsInStock { get; set; }
}
