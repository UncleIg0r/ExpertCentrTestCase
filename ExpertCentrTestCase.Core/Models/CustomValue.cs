namespace ExpertCentrTestCase.Core.Models;

public class CustomValue
{
    public int Id { get; set; }
    public string Value { get; set; } = string.Empty;
    public Column Column { get; set; }
    public Product Product { get; set; }
}
