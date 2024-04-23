using ExpertCentrTestCase.Core.Models;

namespace ExpertCentrTestCase.Core.Interfaces;

public interface IProductRepository
{
    Task<Guid> Create(Product product);
    Task<Guid> Delete(Guid id);
    Task<List<Product>> GetByPriceList(Guid priceListId);
    Task<Product?> GetOne(Guid id);
}