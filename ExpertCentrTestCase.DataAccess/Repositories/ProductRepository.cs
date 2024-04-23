
using ExpertCentrTestCase.Core.Interfaces;
using ExpertCentrTestCase.Core.Models;
using ExpertCentrTestCase.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace ExpertCentrTestCase.DataAccess.Repositories;

public class ProductRepository : IProductRepository
{
    private readonly ApplicationDbContext _context;

    public ProductRepository(ApplicationDbContext context)
    {
        _context = context;
    }
    public async Task<List<Product>> GetByPriceList(Guid priceListId)
    {
        List<ProductEntity> productEntities = await _context.Products.AsNoTracking()
            .Where(p => p.PriceListId == priceListId)
            .Include(p => p.CustomValues)
            .OrderBy(p => p.Name).ToListAsync();
        return productEntities.Select(p => p.MapToProduct()).ToList();
    }
    public async Task<Product?> GetOne(Guid id)
    {
        ProductEntity? productEntity = await _context.Products.AsNoTracking()
            .Include(p => p.CustomValues)
            .FirstOrDefaultAsync(p => p.Id == id) ?? null;
        if (productEntity == null) return null;
        return productEntity.MapToProduct();
    }
    public async Task<Guid> Create(Product product)
    {
        await _context.Products.AddAsync(product.MapToProductEntity());
        await _context.SaveChangesAsync();
        return product.Id;
    }
    public async Task<Guid> Delete(Guid id)
    {
        ProductEntity? productEntity = await _context.Products.AsNoTracking()
            .Include(p => p.CustomValues)
            .FirstOrDefaultAsync(p => p.Id == id) ?? null;
        if (productEntity == null) return Guid.Empty;
        _context.Products.Remove(productEntity);
        await _context.SaveChangesAsync();
        return productEntity.Id;
    }
}
