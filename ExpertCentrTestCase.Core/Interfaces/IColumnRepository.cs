using ExpertCentrTestCase.Core.Models;

namespace ExpertCentrTestCase.Core.Interfaces;

public interface IColumnRepository
{
    Task<Guid> Create(Column column);
    Task<Column?> Get(Guid id);
}