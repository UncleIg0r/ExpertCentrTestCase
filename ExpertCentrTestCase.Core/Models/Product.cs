namespace ExpertCentrTestCase.Core.Models;

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public int Article { get; set; }
    public List<CustomValue> CustomValues { get; set; } = [];
    public PriceList PriceList { get; set; }
}
