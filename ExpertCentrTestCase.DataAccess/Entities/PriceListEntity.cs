using System.ComponentModel.DataAnnotations;

namespace ExpertCentrTestCase.DataAccess.Entities;

public class PriceListEntity
{
    [Key]
    public Guid Id { get; set; }
    public string Name { get; set; }
    public List<ProductEntity> Products { get; set; } = new();
    public List<ColumnEntity> Columns { get; set; } = new();
}
