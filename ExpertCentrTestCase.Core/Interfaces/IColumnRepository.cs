using ExpertCentrTestCase.Core.Models;

namespace ExpertCentrTestCase.Core.Interfaces;

public interface IColumnRepository
{
    Task<int> Create(Column column);
    Task<Column?> Get(int id);
}