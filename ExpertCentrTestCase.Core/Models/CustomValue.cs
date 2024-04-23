namespace ExpertCentrTestCase.Core.Models;

public class CustomValue
{
    public Guid Id { get; set; }
    public string Value { get; set; }
    public Column Column { get; set; }
    public Product Product { get; set; }
}
