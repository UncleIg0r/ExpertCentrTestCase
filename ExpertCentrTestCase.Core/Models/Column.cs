namespace ExpertCentrTestCase.Core.Models;

public class Column
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public ColumnType ColumnType { get; set; }
}
