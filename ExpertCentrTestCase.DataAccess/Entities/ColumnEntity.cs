using ExpertCentrTestCase.Core.Models;
using System.ComponentModel.DataAnnotations;

namespace ExpertCentrTestCase.DataAccess.Entities;

public class ColumnEntity
{
    [Key]
    public int Id { get; set; }
    public ColumnType ColType { get; set; }
    public string ColName { get; set; }
    public List<CustomValueEntity> CustomValues { get; set; } = new();
    public List<PriceListEntity> PriceLists { get; set; } = new();
}
