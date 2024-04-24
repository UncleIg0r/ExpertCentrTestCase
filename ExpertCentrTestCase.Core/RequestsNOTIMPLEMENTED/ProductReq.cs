using ExpertCentrTestCase.Core.Models;

namespace ExpertCentrTestCase.Core.Requests;

public class ProductReq
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public int Article { get; set; }
    public List<int> CustomValueIds { get; set; } = [];
    public int PriceListId { get; set; }
}
