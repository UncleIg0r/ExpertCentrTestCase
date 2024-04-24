using ExpertCentrTestCase.Core.Models;

namespace ExpertCentrTestCase.Core.Interfaces;

public interface IProductRepository
{
    Task<int> Create(Product product);
    Task<int?> Delete(int id);
    Task<List<Product>> GetByPriceList(int priceListId);
    Task<Product?> GetOne(int id);
}