using ExpertCentrTestCase.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace ExpertCentrTestCase.DataAccess.Configurations;

public class ProductConfigurations : IEntityTypeConfiguration<ProductEntity>
{
    public void Configure(EntityTypeBuilder<ProductEntity> builder)
    {
        builder.HasKey(c => c.Id);
        builder.Property<int>("Id")
            .ValueGeneratedOnAdd();

        builder.HasMany(p => p.CustomValues)
            .WithOne(cc => cc.Product)
            .HasForeignKey(cc => cc.ProductId);

        builder.HasOne(p => p.PriceList)
            .WithMany(pl => pl.Products)
            .HasForeignKey(p => p.PriceListId);
    }
}