
using ExpertCentrTestCase.Core.Models;

namespace ExpertCentrTestCase.Core.Requests;

public static class MappingExtentions
{
    public static Column ToModel(this ColumnReq columnReq)
    {
        return new()
        {
            Id = columnReq.Id,
            Name = columnReq.Name,
            ColumnType = columnReq.ColumnType
        };
    }
    public static CustomValue ToModel(this CustomValueReq customValueReq)
    {
        return new()
        {
            Id = customValueReq.Id,
            Value = customValueReq.Value
        };
    }
    public static PriceList ToModel(this PriceListReq priceListReq)
    {
        return new()
        {
            Id = priceListReq.Id,
            Name = priceListReq.Name
        };
    }
    public static Product ToModel(this ProductReq productReq)
    {
        return new()
        {
            Id = productReq.Id,
            Name = productReq.Name,
            Article = productReq.Article
        };
    }
}
