using ExpertCentrTestCase.Core.Models;

namespace ExpertCentrTestCase.Core.Interfaces;

public interface IPriceListRepository
{
    Task<Guid> Create(PriceList priceList);
    Task<Guid> Delete(Guid id);
    Task<List<PriceList>> GetAll();
    Task<PriceList?> GetOne(Guid id);
}