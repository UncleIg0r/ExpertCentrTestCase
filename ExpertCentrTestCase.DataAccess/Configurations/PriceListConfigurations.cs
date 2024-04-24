using ExpertCentrTestCase.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace ExpertCentrTestCase.DataAccess.Configurations;

public class PriceListConfigurations : IEntityTypeConfiguration<PriceListEntity>
{
    public void Configure(EntityTypeBuilder<PriceListEntity> builder)
    {
        builder.HasKey(pl => pl.Id);
        builder.Property<int>("Id")
            .ValueGeneratedOnAdd();

        builder.HasMany(pl => pl.Columns)
            .WithMany(c => c.PriceLists);

        builder.HasMany(pl => pl.Products)
            .WithOne(p => p.PriceList)
            .HasForeignKey(p => p.PriceListId);
    }
}