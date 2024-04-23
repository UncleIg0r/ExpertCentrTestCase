using ExpertCentrTestCase.Core.Models;

namespace ExpertCentrTestCase.Core.Interfaces;

public interface ICustomValueRepository
{
    Task<List<Guid>> Create(List<CustomValue> customValues);
    Task<List<Guid>> DeleteAllByProduct(Guid productId);
    Task<List<CustomValue>> GetAllByProduct(Guid productId);
    Task<CustomValue?> GetOne(Guid id);
}