using System.ComponentModel.DataAnnotations;

namespace ExpertCentrTestCase.Models;

public class Product
{
    public Product(int id, string name, int article, int priceListId)
    {
        Id = id;
        Name = name;
        Article = article;
        PriceListId = priceListId;
    }

    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
    public int Article { get; set; }
    public List<CustomProductColumn> CustomProductColumns { get; set; } = new();
    public int PriceListId { get; set; }
    public PriceList? PriceList { get; set; }

}
