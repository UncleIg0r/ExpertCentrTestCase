using System.ComponentModel.DataAnnotations;

namespace ExpertCentrTestCase.DataAccess.Entities;

public class CustomValueEntity
{
    [Key]
    public int Id { get; set; }
    public string? Value { get; set; }
    public int ProductId { get; set; }
    public ProductEntity? Product { get; set; }
    public int ColumnId { get; set; }
    public ColumnEntity? Column { get; set; }

}
