using ExpertCentrTestCase.Core.Models;

namespace ExpertCentrTestCase.Core.Interfaces;

public interface ICustomValueRepository
{
    Task<List<int>> Create(List<CustomValue> customValues);
    Task<List<int>> DeleteAllByProduct(int productId);
    Task<List<CustomValue>> GetAllByProduct(int productId);
    Task<CustomValue?> GetOne(int id);
}