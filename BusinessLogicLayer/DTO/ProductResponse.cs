namespace eCommerce.BusinessLogicLayer.DTO;

public record ProductResponse(Guid ProductID, string ProductName, CategoryOptions Category, double? UnitPrice, int? QuantityInStock)
{
    public ProductResponse() : this(Guid.Empty, string.Empty, default, null, null)
    {
    }
}
