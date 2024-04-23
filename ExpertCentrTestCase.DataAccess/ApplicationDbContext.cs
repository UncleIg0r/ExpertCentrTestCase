using ExpertCentrTestCase.DataAccess.Configurations;
using ExpertCentrTestCase.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace ExpertCentrTestCase.DataAccess;

public class ApplicationDbContext : DbContext
{
    public DbSet<ColumnEntity> Columns => Set<ColumnEntity>();
    public DbSet<CustomValueEntity> CustomValues => Set<CustomValueEntity>();
    public DbSet<PriceListEntity> PriceLists => Set<PriceListEntity>();
    public DbSet<ProductEntity> Products => Set<ProductEntity>();

    public ApplicationDbContext() => Database.EnsureCreated();
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
        Database.EnsureCreated();
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new ColumnConfigurations());
        modelBuilder.ApplyConfiguration(new CustomValueConfigurations());
        modelBuilder.ApplyConfiguration(new PriceListConfigurations());
        modelBuilder.ApplyConfiguration(new ProductConfigurations());


        base.OnModelCreating(modelBuilder);
    }

}
