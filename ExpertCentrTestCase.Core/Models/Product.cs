namespace ExpertCentrTestCase.Core.Models;

public class Product
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public int Article { get; set; }
    public List<CustomValue> CustomValues { get; set; } = [];
    public PriceList PriceList { get; set; }
}
