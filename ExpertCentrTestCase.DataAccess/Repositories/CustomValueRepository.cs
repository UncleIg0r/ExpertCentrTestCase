using ExpertCentrTestCase.Core.Interfaces;
using ExpertCentrTestCase.Core.Models;
using ExpertCentrTestCase.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace ExpertCentrTestCase.DataAccess.Repositories;

public class CustomValueRepository : ICustomValueRepository
{
    private readonly ApplicationDbContext _context;

    public CustomValueRepository(ApplicationDbContext context)
    {
        _context = context;
    }
    public async Task<CustomValue?> GetOne(int id)
    {
        CustomValueEntity? customValueEntity = await _context.CustomValues.AsNoTracking()
            .FirstOrDefaultAsync(cv => cv.Id == id) ?? null;
        if (customValueEntity == null) return null;
        return customValueEntity.MapToCustomValue();
    }
    public async Task<List<CustomValue>> GetAllByProduct(int productId)
    {
        List<CustomValueEntity> customValues = await _context.CustomValues.AsNoTracking()
            .Where(cv => cv.ProductId == productId)
            .OrderBy(cv => cv.ColumnId).ToListAsync();
        return customValues.Select(cv => cv.MapToCustomValue()).ToList();
    }
    public async Task<List<int>> DeleteAllByProduct(int productId)
    {
        var toDel = await _context.CustomValues.AsNoTracking()
            .Where(cv => cv.ProductId == productId).ToArrayAsync();
        _context.CustomValues.RemoveRange(toDel);
        await _context.SaveChangesAsync();
        return toDel.Select(d => d.Id).ToList();
    }
    public async Task<List<int>> Create(List<CustomValue> customValues)
    {
        await _context.CustomValues.AddRangeAsync(customValues
            .Select(cv => cv.MapToCustomValueEntity())
            );
        await _context.SaveChangesAsync();
        return customValues.Select(cv => cv.Id).ToList();
    }
}
