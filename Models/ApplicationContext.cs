using Microsoft.EntityFrameworkCore;

namespace ExpertCentrTestCase.Models;

public class ApplicationContext : DbContext
{
    public DbSet<Column> Columns => Set<Column>();
    public DbSet<CustomProductColumn> CustomProductColumns => Set<CustomProductColumn>();
    public DbSet<PriceList> PriceLists => Set<PriceList>();
    public DbSet<Product> Products => Set<Product>();

    public ApplicationContext() => Database.EnsureCreated();
    public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
    {
        Database.EnsureCreated();
    }

}
