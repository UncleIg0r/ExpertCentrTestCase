using ExpertCentrTestCase.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace ExpertCentrTestCase.DataAccess.Configurations;

public class ColumnConfigurations : IEntityTypeConfiguration<ColumnEntity>
{
    public void Configure(EntityTypeBuilder<ColumnEntity> builder)
    {
        builder.HasKey(c => c.Id);
        builder.Property<Guid>("Id")
            .ValueGeneratedOnAdd();

        builder.HasMany(c => c.CustomValues)
            .WithOne(cc => cc.Column)
            .HasForeignKey(cc => cc.ColumnId);

        builder.HasMany(c => c.PriceLists)
            .WithMany(p => p.Columns);
    }
}
