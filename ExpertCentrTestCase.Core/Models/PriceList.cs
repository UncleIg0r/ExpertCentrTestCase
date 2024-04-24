using System.ComponentModel.DataAnnotations;

namespace ExpertCentrTestCase.Core.Models;

public class PriceList
{
    public int Id { get; set; }
    [Required]
    public string Name { get; set; } = string.Empty;
    public List<Product> Products { get; set; } = [];
    public List<Column> Columns { get; set; } = [];
}
