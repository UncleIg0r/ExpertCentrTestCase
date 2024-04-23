﻿namespace ExpertCentrTestCase.Core.Models;

public class PriceList
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public List<Product> Products { get; set; } = [];
    public List<Column> Columns { get; set; } = [];
}
