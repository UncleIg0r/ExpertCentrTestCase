using ExpertCentrTestCase.Core.Interfaces;
using ExpertCentrTestCase.Core.Models;
using ExpertCentrTestCase.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace ExpertCentrTestCase.DataAccess.Repositories;

public class PriceListRepository : IPriceListRepository
{
    private readonly ApplicationDbContext _context;
    public PriceListRepository(ApplicationDbContext context)
    {
        _context = context;
    }
    public async Task<List<PriceList>> GetAll()
    {
        List<PriceListEntity> priceListEntities = await _context.PriceLists.AsNoTracking()
            .OrderBy(pl => pl.Name).ToListAsync();
        return priceListEntities.Select(pl => pl.MapToPriceList()).ToList();
    }
    public async Task<PriceList?> GetOne(int id)
    {
        PriceListEntity? priceListEntity = await _context.PriceLists.AsNoTracking()
            .Include(pl => pl.Columns).Include(pl => pl.Products)
            .FirstOrDefaultAsync(p => p.Id == id) ?? null;
        if (priceListEntity == null) return null;
        return priceListEntity.MapToPriceList();
    }
    public async Task<int> Create(PriceList priceList)
    {
        await _context.PriceLists.AddAsync(priceList.MapToPriceListEntity());
        await _context.SaveChangesAsync();
        return priceList.Id;
    }
    public async Task<int?> Delete(int id)
    {
        PriceListEntity? priceList = await _context.PriceLists.AsNoTracking()
            .FirstOrDefaultAsync(pl => pl.Id == id) ?? null;
        if (priceList == null) return null;
        _context.PriceLists.Remove(priceList);
        await _context.SaveChangesAsync();
        return priceList.Id;
    }
}
