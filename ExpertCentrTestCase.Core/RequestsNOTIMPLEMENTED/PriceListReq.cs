
using ExpertCentrTestCase.Core.Models;

namespace ExpertCentrTestCase.Core.Requests;

public class PriceListReq
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public List<int> ProductIds { get; set; } = [];
    public List<int> ColumnIds { get; set; } = [];
}

