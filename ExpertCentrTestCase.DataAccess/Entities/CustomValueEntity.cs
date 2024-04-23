using System.ComponentModel.DataAnnotations;

namespace ExpertCentrTestCase.DataAccess.Entities;

public class CustomValueEntity
{
    [Key]
    public Guid Id { get; set; }
    public string? Value { get; set; }
    public Guid ProductId { get; set; }
    public ProductEntity? Product { get; set; }
    public Guid ColumnId { get; set; }
    public ColumnEntity? Column { get; set; }

}
