using ExpertCentrTestCase.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace ExpertCentrTestCase.DataAccess.Configurations;

public class CustomValueConfigurations : IEntityTypeConfiguration<CustomValueEntity>
{
    public void Configure(EntityTypeBuilder<CustomValueEntity> builder)
    {
        builder.HasKey(c => c.Id);
        builder.Property<int>("Id")
            .ValueGeneratedOnAdd();

        builder.HasOne(cc => cc.Column)
            .WithMany(c => c.CustomValues)
            .HasForeignKey(cc => cc.ColumnId);
    }
}