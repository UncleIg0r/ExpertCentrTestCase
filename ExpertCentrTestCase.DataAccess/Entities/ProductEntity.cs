using System.ComponentModel.DataAnnotations;

namespace ExpertCentrTestCase.DataAccess.Entities;

public class ProductEntity
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
    public int Article { get; set; }
    public List<CustomValueEntity> CustomValues { get; set; } = new();
    public int PriceListId { get; set; }
    public PriceListEntity? PriceList { get; set; }

}
