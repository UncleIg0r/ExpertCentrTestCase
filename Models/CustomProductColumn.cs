using System.ComponentModel.DataAnnotations;

namespace ExpertCentrTestCase.Models;

public class CustomProductColumn
{
    [Key]
    public int Id { get; set; }
    public string? Value { get; set; }
    public int ProductId { get; set; }
    public Product? Products { get; set; }
    public int ColumnId { get; set; }
    public Column? Column { get; set; }

}
