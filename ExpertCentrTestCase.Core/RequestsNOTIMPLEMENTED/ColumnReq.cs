
using ExpertCentrTestCase.Core.Models;

namespace ExpertCentrTestCase.Core.Requests;

public class ColumnReq
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public ColumnType ColumnType { get; set; }
}
