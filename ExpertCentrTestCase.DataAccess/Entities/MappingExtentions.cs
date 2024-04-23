using ExpertCentrTestCase.Core.Models;

namespace ExpertCentrTestCase.DataAccess.Entities;

public static class MappingExtentions
{
    public static Column MapToColumn(this ColumnEntity? columnEntity)
    {
        if (columnEntity == null) throw new ArgumentNullException(nameof(columnEntity));

        Column column = new()
        {
            Id = columnEntity.Id,
            Name = columnEntity.ColName,
            ColumnType = columnEntity.ColType,
        };
        return column;
    }
    public static ColumnEntity MapToColumnEntity(this Column? column)
    {
        if (column == null) throw new ArgumentNullException(nameof(column));

        ColumnEntity columnEntity = new()
        {
            Id = column.Id,
            ColName = column.Name,
            ColType = column.ColumnType,
        };
        return columnEntity;
    }
    public static CustomValue MapToCustomValue(this CustomValueEntity? customValueEntity)
    {
        if (customValueEntity == null) throw new ArgumentNullException(nameof(customValueEntity));

        CustomValue customColumnValue = new()
        {
            Id = customValueEntity.Id,
            Value = customValueEntity.Value,
            Column = customValueEntity.Column.MapToColumn(),
            Product = customValueEntity.Product.MapToProduct()
        };
        return customColumnValue;
    }
    public static CustomValueEntity MapToCustomValueEntity(this CustomValue? customValue)
    {
        if (customValue == null) throw new ArgumentNullException(nameof(customValue));

        CustomValueEntity customValueEntity = new()
        {
            Id = customValue.Id,
            Value = customValue.Value,
            Column = customValue.Column.MapToColumnEntity(),
            ColumnId = customValue.Column.Id,
            Product = customValue.Product.MapToProductEntity(),
            ProductId = customValue.Product.Id
        };
        return customValueEntity;
    }
    public static Product MapToProduct(this ProductEntity? productEntity)
    {
        if (productEntity == null) throw new ArgumentNullException(nameof(productEntity));

        Product product = new()
        {
            Id = productEntity.Id,
            Name = productEntity.Name,
            CustomValues = productEntity.CustomValues.Select(ccv => ccv.MapToCustomValue()).ToList(),
            Article = productEntity.Article,
            PriceList = productEntity.PriceList.MapToPriceList()
        };
        return product;
    }
    public static ProductEntity MapToProductEntity(this Product? product)
    {
        if (product == null) throw new ArgumentNullException(nameof(product));

        ProductEntity productEntity = new()
        {
            Id = product.Id,
            Name = product.Name,
            CustomValues = product.CustomValues.Select(ccv => ccv.MapToCustomValueEntity()).ToList(),
            Article = product.Article,
            PriceList = product.PriceList.MapToPriceListEntity(),
            PriceListId = product.PriceList.Id
        };
        return productEntity;
    }
    public static PriceList MapToPriceList(this PriceListEntity? priceListEntity)
    {
        if (priceListEntity == null) throw new ArgumentNullException(nameof(priceListEntity));

        PriceList priceList = new()
        {
            Id = priceListEntity.Id,
            Name = priceListEntity.Name,
            Columns = priceListEntity.Columns.Select(pl => pl.MapToColumn()).ToList(),
            Products = priceListEntity.Products.Select(pl => pl.MapToProduct()).ToList()
        };
        return priceList;
    }
    public static PriceListEntity MapToPriceListEntity(this PriceList? priceList)
    {
        if (priceList == null) throw new ArgumentNullException(nameof(priceList));

        PriceListEntity priceListEntity = new()
        {
            Id = priceList.Id,
            Name = priceList.Name,
            Columns = priceList.Columns.Select(pl => pl.MapToColumnEntity()).ToList(),
            Products = priceList.Products.Select(pl => pl.MapToProductEntity()).ToList()
        };
        return priceListEntity;
    }
}
