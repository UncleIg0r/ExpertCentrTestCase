
using ExpertCentrTestCase.Core.Interfaces;
using ExpertCentrTestCase.Core.Models;
using ExpertCentrTestCase.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace ExpertCentrTestCase.DataAccess.Repositories;

public class ColumnRepository : IColumnRepository
{
    private readonly ApplicationDbContext _context;

    public ColumnRepository(ApplicationDbContext context)
    {
        _context = context;
    }
    public async Task<Column?> Get(Guid id)
    {
        ColumnEntity? columnEntity = await _context.Columns.AsNoTracking()
            .FirstOrDefaultAsync(c => c.Id == id) ?? null;
        if (columnEntity == null) return null;
        return columnEntity.MapToColumn();
    }
    public async Task<Guid> Create(Column column)
    {
        await _context.AddAsync(column.MapToColumnEntity());
        await _context.SaveChangesAsync();
        return column.Id;
    }

}
