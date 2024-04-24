using ExpertCentrTestCase.Core.Models;

namespace ExpertCentrTestCase.Core.Interfaces;

public interface IPriceListRepository
{
    Task<int> Create(PriceList priceList);
    Task<int?> Delete(int id);
    Task<List<PriceList>> GetAll();
    Task<PriceList?> GetOne(int id);
}