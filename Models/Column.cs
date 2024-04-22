using System.ComponentModel.DataAnnotations;

namespace ExpertCentrTestCase.Models;

public class Column
{
    [Key]
    public int Id { get; set; }
    public ColumnType ColType { get; set; }
    public string ColName { get; set; }
    public List<CustomProductColumn> CustomProductColumns { get; set; } = new();
    public List<PriceList> PriceLists { get; set; } = new();
}
public enum ColumnType
{
    Number,//число
    String, //Однострочный текст
    Text //Многострочный текст
}
