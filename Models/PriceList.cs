using System.ComponentModel.DataAnnotations;

namespace ExpertCentrTestCase.Models;

public class PriceList
{
    [Key]
    public int Id { get; set; }
    [Required(ErrorMessage ="Это поле обязательно к заполнению!")]
    public string Name { get; set; }
    public List<Product> Products { get; set; } = new();
    public List<Column> Columns { get; set; } = new();
}
